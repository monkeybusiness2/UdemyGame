using Unity.VisualScripting;
using UnityEngine;

public abstract class EntityState //should be parent class a base class
{
    protected StateMachine stateMachine;
    protected string stateName;
    protected Player player;


    public EntityState(Player player, StateMachine stateMachine, string stateName)
    {
        this.stateMachine = stateMachine;
        this.stateName = stateName; //construncter
        this.player = player;
    }

    public virtual void Enter()
    {
      //  Debug.Log("I enter" + stateName);
    }

    public virtual void Update()
    {
      //  Debug.Log("I run update of" + stateName);
    }

    public virtual void Exit()
    {
      //  Debug.Log("I exit" + stateName);
    }
}
