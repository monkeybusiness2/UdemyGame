using UnityEngine;

public class Player_FallState : EntityState
{
    public Player_FallState (Player player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Update()
    {
        base.Update();
        if (player.groundDetected)
            stateMachine.ChangeState(player.idleState);
        //CHECK IF PLAYUER DETECTING THE Ground below, if yes ... go to idle state
    }
}
