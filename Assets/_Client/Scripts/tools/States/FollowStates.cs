﻿using UnityEngine.AI;
using UnityEngine;
using Tools;

namespace Tools
{
    public class FollowStates : EnemyState
    {
        private Transform thisGameObjectTransform;

        public FollowStates(NavMeshAgent agent, Transform thisTransform)
        {
            _agent = agent;
            thisGameObjectTransform = thisTransform;    
        }

        public override void Enter()
        {


        }

        public override void Exit()
        {

        }

        public override void Update()
        {

        }

    }
}