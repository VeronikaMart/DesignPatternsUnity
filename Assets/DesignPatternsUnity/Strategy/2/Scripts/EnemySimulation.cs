using UnityEngine;

namespace Patterns2022.Strategy
{
    public enum EnemyType
    {
        Soldier,
        Shooter,
        Boss
    }
    
    public class EnemySimulation : MonoBehaviour
    {
        [SerializeField] private EnemyType enemyType;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                switch (enemyType)
                {
                    case EnemyType.Soldier:
                        Enemy enemySoldier = new EnemySoldier();
                        enemySoldier.Display();
                        break;
                    case EnemyType.Shooter:
                        Enemy enemyShooter = new EnemyShooter();
                        enemyShooter.Display();
                        break;
                    case EnemyType.Boss:
                        Enemy enemyBoss = new EnemyBoss();
                        enemyBoss.Display();

                        // Can be used as a debuff on an enemy
                        //enemyBoss.SetKickBehavior(new NoKick());
                        //enemyBoss.PerformKick();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}