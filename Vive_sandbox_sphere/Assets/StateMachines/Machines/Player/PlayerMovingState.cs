using UnityEngine;
using System.Collections;

public class PlayerMovingState : StateBase<PlayerStates, PlayerMachine>
{
    public override void Awake()
    {
        base.Awake();
        stateEnum = PlayerStates.Moving;
	}

	void OnEnable()
	{
	}

	void Update()
	{
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Machine.SetState(PlayerStates.Death);
        }
        else if (Input.GetKeyUp(KeyCode.Return))
        {
            Machine.SetState(PlayerStates.Idle);
        }
    }

	void OnDisable()
	{
	}
}
