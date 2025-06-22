using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private StateMachine stateMachine;
    public  PlayerIdleState idleState { get; private set; }
    public PlayerMoveState moveState { get; private set; }

    private void Awake()
    {
        stateMachine = new StateMachine();

        idleState = new PlayerIdleState(this, stateMachine, "idle");
        moveState = new PlayerMoveState(this, stateMachine, "move");
    }

    private void Start()
    {
        stateMachine.Intialize(idleState);
    }

    private void Update()
    {
        stateMachine.currentState.Update();
    }

}
