using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public StateMachine stateMachine { get; private set; }
    private EntityState idleState;

    private void Awake()
    {
        stateMachine = new StateMachine();

        idleState = new EntityState(stateMachine, "Idle State");
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
