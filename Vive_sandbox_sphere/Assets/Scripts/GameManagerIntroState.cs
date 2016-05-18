using UnityEngine;
using System.Collections;

public class GameManagerIntroState : StateBase<GameManagerStates, GameManagerMachine>
{
	public override void Awake()
	{
		base.Awake();
		stateEnum = GameManagerStates.Intro;
	}

	void OnEnable()
	{
	}

	void Update()
	{
        //wait for press play
	}

	void OnDisable()
	{
	}
}
