using UnityEngine;
using System.Collections;

public class GameManagerPlayingState : StateBase<GameManagerStates, GameManagerMachine>
{
    public GameObject playingTicker;



    private Rigidbody rb;
    public float amount = 50f;

    void Start()
    {
        rb = playingTicker.GetComponent<Rigidbody>();

    }

    public override void Awake()
	{
		base.Awake();
		stateEnum = GameManagerStates.Playing;

        
    }

	void OnEnable()
	{
	}

	void Update()
	{
        //count the timer down
        //tick the table
        float v = amount * Time.deltaTime;
        rb.AddTorque(transform.forward * v);
    }

	void OnDisable()
	{
	}
}
