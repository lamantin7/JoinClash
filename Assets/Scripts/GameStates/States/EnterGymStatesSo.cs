using GameStates.Base;
using SceneLoading;
using System.Collections;
using UnityEngine;

namespace GameStates.States
{
    [CreateAssetMenu(fileName ="EnterGymState", menuName = "ScriptableObjects/Game/States/GameState")]
    public class EnterGymStatesSo : GameStateSo
    {
        [SerializeField] private Scene _gym;

        private readonly IAsyncSceneLoading _sceneLoading=new AddressablesSceneLoading();
        public override void Enter() => _sceneLoading.LoadAsync(_gym); 

        public override void Exit()
        {
           
        }

       
    }
}