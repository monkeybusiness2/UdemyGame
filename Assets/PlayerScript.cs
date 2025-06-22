using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private PlayerInputSet input;
    private StateMachine stateMachine;
    public  PlayerIdleState idleState { get; private set; }
    public PlayerMoveState moveState { get; private set; }

    private void Awake()
    {
        stateMachine = new StateMachine();
        input = new PlayerInputSet();

        idleState = new PlayerIdleState(this, stateMachine, "idle");
        moveState = new PlayerMoveState(this, stateMachine, "move");
    }

    private void OnEnable()
    {
        input.Enable();

        input.Player.Movement.performed += ctx => Debug.Log(ctx.ReadValue<Vector2>());
        
    }

    private void OnDisable()
    {
        input.Disable();
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
