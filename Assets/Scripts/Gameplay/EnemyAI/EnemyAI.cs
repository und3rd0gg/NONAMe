using NONAMe.Gameplay.EnemyAI.States;
using UnityEngine;

namespace NONAMe.Gameplay.EnemyAI
{
    public class EnemyAI : MonoBehaviour
    {
        private EnemyStateMachine _enemyStateMachine;

        private void Awake()
        {
            _enemyStateMachine = new EnemyStateMachine();
            _enemyStateMachine.Enter<IdleState>();
        }
    }
}