using UnityEngine;
using System.Collections;

public class GameManagerLoseState : StateBase<GameManagerStates, GameManagerMachine>
{
	public override void Awake()
	{
		base.Awake();
		stateEnum = GameManagerStates.Lose;
	}

	void OnEnable()
	{
	}

	void Update()
	{
	}

	void OnDisable()
	{
	}
}
