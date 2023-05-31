using GameStates.Base;
using GameStates.States;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private GameStateMachineSo _stateMachine;

    private void OnEnable() => _stateMachine.Enter<EnterGymStatesSo>();
}
