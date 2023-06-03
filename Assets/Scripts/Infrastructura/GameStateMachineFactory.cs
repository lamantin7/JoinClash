using GameStates.Base;
using GameStates.States;
using SceneLoading;
using System.Collections;
using UnityEngine;

namespace Infrastructura
{
    
    public class GameStateMachineFactory: MonoBehaviour
    {
        [SerializeField] private Scene _level;
        [SerializeField] private Scene _menu;

        public IGameStateMachine Initialize()
        {
            IAsyncSceneLoading sceneLoading = new AddressablesSceneLoading();

            IGameState[] states =
            {
                new BootstrapState(_level, _menu, sceneLoading),
                new GameplayState (_menu, sceneLoading)
            };
            return new GameStateMachine(states);
        }

        
    }
}