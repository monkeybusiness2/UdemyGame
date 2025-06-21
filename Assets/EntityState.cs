using Unity.VisualScripting;
using UnityEngine;

public class EntityState
{
    protected StateMachine statemachine;

    public EntityState(StateMachine stateMachie)
    {
        this.statemachine = statemachine;
    }

    public virtual void Enter()
    {
        
    }

    public virtual void Update()
    {
        
    }

    public virtual void Exit()
    {

    }
}
