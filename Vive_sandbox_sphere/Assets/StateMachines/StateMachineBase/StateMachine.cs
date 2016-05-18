using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class StateMachine<TEnum, TMachine> :  MonoBehaviour {

    protected StateBase<TEnum, TMachine>[] states;
    public StateBase<TEnum, TMachine>[] States
    {
        get { return states; }
    }


    protected StatesController stateController; // !! this does nothing rite now
    protected TEnum currentState; // states are enums into the component hashtable
    protected TEnum lastState;
    protected Dictionary<TEnum, StateBase<TEnum, TMachine>> statesTable;

    // This is the type of StateMachine -Ex: PlayerMachine, StageMachine ect.
    protected System.Type type;

    protected bool isChangingState = false;

    public bool allowLogging = false;


    public StateMachine()
    {
        if (!typeof(TEnum).IsEnum)
        {
            throw new ArgumentException("TEnum must be an enumeration");
        }
    }

    // Use this for initialization
    protected virtual void Awake()
    {
        if (stateController != null) { return; }

        type = this.GetType();

        stateController = GetComponentInChildren<StatesController>();
        states = stateController.GetComponents<StateBase<TEnum, TMachine>>();
        InitializeAllStates();
    }

    protected void InitializeAllStates()
    {
        statesTable = new Dictionary<TEnum, StateBase<TEnum, TMachine>>();

        foreach (StateBase<TEnum, TMachine> state in states)
        {
            state.enabled = false;
            state.Machine = GetComponent<TMachine>();
            state.Init();
            statesTable.Add(state.StateEnum, state);
        }
    }

    public virtual bool SetState(TEnum _newState)
    {

        // This prevents SetState from getting called twice in the same frame.
        if ( statesTable.ContainsKey(currentState)  &&
            (isChangingState || statesTable[currentState] == statesTable[_newState]) ) { return false; }
        
        isChangingState = true;

        // Dont allow to trigger if same state
        if (lastState != null && statesTable.ContainsKey(lastState))
        {
            MLog("EXIT: " + statesTable[lastState]);

            if (statesTable[lastState].enabled == true)
            {
                statesTable[lastState].enabled = false;
            }
        }

        currentState = _newState;

        if (statesTable[currentState].enabled == false)
        {
            statesTable[currentState].enabled = true;
        }

        lastState = _newState;

        isChangingState = false;

        MLog("ENTER: " + statesTable[currentState]);

        return true;

    }

    public TEnum GetCurrentState()
    {
        return currentState;
    }

    public void MLog(string _str)
    {
        if (allowLogging)
        {
            Debug.Log(_str);
        }
    }

}
