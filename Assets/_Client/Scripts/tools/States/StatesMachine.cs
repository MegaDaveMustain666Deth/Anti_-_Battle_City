namespace Tools
{
    public class StateMachine
    {
        private EnemyState _currentState;

        public StateMachine(EnemyState startState)
        {
            _currentState = startState;
            _currentState.Enter();
        }

        public void ChangeState(EnemyState newState)
        {
            _currentState.Exit();
            _currentState = newState;
            _currentState.Enter();
        }

        public void Update()
        {
            _currentState.Update();
        }
    }
}