using UnityEngine.AI;
using UnityEngine;
using Tools;

public class Enemy : UnitController
{
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private float FollowDistanse;
    [SerializeField] private float AttackDistance;
    
    
    private StateMachine _stateMachine;

    public override void Initialize()
    {
        base.Initialize();
        _stateMachine = new StateMachine(new IdleStates());
    }

    private void Update()
    {
        _stateMachine.Update();

        float toPlayer = Vector2.Distance(Player.Instance.transform.position, transform.position);
        if (toPlayer < FollowDistanse)
        {
            _stateMachine.ChangeState(new IdleStates());    
            print("follow");
        }
        else if (FollowDistanse >= toPlayer && toPlayer >= AttackDistance)
        {
            _stateMachine.ChangeState(new FollowStates(_agent, gameObject.transform));
            print("follow");
        }
        else if(AttackDistance <= toPlayer)
        {
            _stateMachine.ChangeState(new AttackState(_agent));
            print("attack");
        }
    }
}