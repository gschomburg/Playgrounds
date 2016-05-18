using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;


public abstract class StateBase<T, TMachine> : MonoBehaviour {

	protected T stateEnum;
    public T StateEnum
    {
        get { return stateEnum; }
    }

    //protected T nextState;

	private TMachine stateMachine;
    public TMachine Machine
    {
        get { return stateMachine; }
        set { stateMachine = value; }
    }

	protected System.Type type;

	public virtual void Awake()
	{
		type = this.GetType();
	}

	public virtual void Init()
	{
	}
}

public abstract class  MenuBaseState <T, TMachine> : StateBase<T, TMachine> {
	
}
