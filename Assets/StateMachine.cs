using UnityEngine;

public class StateMachine
{
    public EntityState currentState { get; private set; } //anyone cane see it but nobody can change it

    public void Intialize(EntityState startState)
    {
        currentState = startState;
        currentState.Enter();
    }

    public void ChangeState(EntityState newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }
}
    
