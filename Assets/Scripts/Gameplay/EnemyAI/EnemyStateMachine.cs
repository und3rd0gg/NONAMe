using System;
using System.Collections.Generic;
using NONAMe.Gameplay.EnemyAI.States;

namespace NONAMe.Gameplay.EnemyAI
{
    public class EnemyStateMachine : StateMachine
    {
        public EnemyStateMachine()
        {
            InitializeStateMap();
        }
        
        private void InitializeStateMap()
        {
            States = new Dictionary<Type, IExitableState>()
            {
                [typeof(IdleState)] = new IdleState(),
                [typeof(PatrolState)] = new PatrolState(),
                [typeof(ChaseState)] = new ChaseState(),
            };
        }
    }
}