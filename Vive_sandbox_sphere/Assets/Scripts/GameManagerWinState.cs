using UnityEngine;
using System.Collections;

public class GameManagerWinState : StateBase<GameManagerStates, GameManagerMachine>
{
	public override void Awake()
	{
		base.Awake();
		stateEnum = GameManagerStates.Win;
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
