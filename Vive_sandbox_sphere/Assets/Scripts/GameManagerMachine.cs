using UnityEngine;
using System.Collections;
using NewtonVR;

public enum GameManagerStates
{
	NONE,
	Intro,
	Playing,
	Win,
	Lose,
};

public class GameManagerMachine : StateMachine<GameManagerStates, GameManagerMachine>
{
    public NVRButton playButton;
    public NVRButton resetButton;

    public GameObject 

    //private int testProperty;
    //public int TestPropert
    //{
    //    get { return testProperty; }
    //    set { testProperty = value; }
    //}
    void Start()
    {
        SetState(GameManagerStates.Intro);
    }

    void OnEnable()
    {
    }

    private void Update()
    {
        if (playButton.ButtonDown)
        {
            SetState(GameManagerStates.Playing);
        }
        if (resetButton.ButtonDown)
        {
            SetState(GameManagerStates.Intro);
        }
    }
}
