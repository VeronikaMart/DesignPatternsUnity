using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Command
{
    public class InputHandler : MonoBehaviour
    {
        //Stores all commands for replay and undo
        public static List<Command> oldCommands = new List<Command>();
        public static bool shouldStartReplay;

        [SerializeField] private Transform playerTransform;
        private Command
            buttonW,
            buttonS,
            buttonA,
            buttonD,
            buttonZ,
            buttonR;

        //Player start position to know where replay begins
        private Vector3 startPos;
        //To reset the coroutine
        private Coroutine replayCoroutine;
        //So we cant press keys while replaying
        private bool isReplaying;

        private void Start()
        {
            buttonW = new MoveForward();
            buttonS = new MoveBack();
            buttonA = new MoveLeft();
            buttonD = new MoveRight();
            buttonZ = new UndoCommand();
            buttonR = new ReplayCommand();

            startPos = playerTransform.position;
        }

        private void Update()
        {
            if (!isReplaying)
            {
                GetInput();
            }

            StartReplay();
        }

        private void GetInput()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                buttonA.Execute(playerTransform, buttonA);
            }

            else if (Input.GetKeyDown(KeyCode.D))
            {
                buttonD.Execute(playerTransform, buttonD);
            }

            else if (Input.GetKeyDown(KeyCode.R))
            {
                buttonR.Execute(playerTransform, buttonZ);
            }

            else if (Input.GetKeyDown(KeyCode.S))
            {
                buttonS.Execute(playerTransform, buttonS);
            }

            else if (Input.GetKeyDown(KeyCode.W))
            {
                buttonW.Execute(playerTransform, buttonW);
            }

            else if (Input.GetKeyDown(KeyCode.Z))
            {
                buttonZ.Execute(playerTransform, buttonZ);
            }
        }

        //Checks if we should start the replay
        private void StartReplay()
        {
            if (shouldStartReplay && oldCommands.Count > 0)
            {
                shouldStartReplay = false;

                //Stop the coroutine so it starts from the beginning
                if (replayCoroutine != null)
                {
                    StopCoroutine(replayCoroutine);
                }

                //Start the replay
                replayCoroutine = StartCoroutine(ReplayCommands(playerTransform));
            }
        }

        IEnumerator ReplayCommands(Transform transform)
        {
            //So we can't move with keys while replaying
            isReplaying = true;

            transform.position = startPos;

            for (int i = 0; i < oldCommands.Count; i++)
            {
                //Move with the current command
                oldCommands[i].Move(transform);

                yield return new WaitForSeconds(0.3f);
            }

            //We can move again
            isReplaying = false;
        }
    }
}