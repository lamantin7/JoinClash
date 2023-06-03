using GameStates.Base;
using GameStates.States;
using Infrastructura;
using StaticContext;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private GameStateMachineFactory _stateMachineFactory;

    private void OnEnable()
    {
        IGameStateMachine stateMachine = _stateMachineFactory.Initialize();
        Instance<IGameStateMachine>.Value = stateMachine;
       stateMachine.Enter<BootstrapState>();
    }
}
