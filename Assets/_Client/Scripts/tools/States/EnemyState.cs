using UnityEngine.AI;
using UnityEngine;

namespace Tools
{
    public abstract class EnemyState
    {
        public NavMeshAgent _agent;

        public abstract void Enter();
        public abstract void Exit();
        public abstract void Update();
    }
}
