using UnityEngine;
using System.Collections;

public enum PlayerStates
{
    NONE,
	Idle,
	Moving,
	Death,
};

public class PlayerMachine : StateMachine<PlayerStates, PlayerMachine>
{

    private  int testProperty;
    public int TestPropert
    {
        get { return testProperty; }
        set { testProperty = value; }
    }

    void Start()
	{
        print("START");
        // Enables Idle state
        SetState(PlayerStates.Idle);
	}

	void OnEnable()
	{
        // Init machine here
	}
}
