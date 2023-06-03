using GameStates.Base;
using SceneLoading;
using System.Collections;
using UnityEngine;

namespace GameStates.States
{
    
    public class BootstrapState : IGameState
    {
        private readonly Scene _level;
        private readonly Scene _menu;

        private readonly IAsyncSceneLoading _sceneLoading;

        public BootstrapState(Scene gym, IAsyncSceneLoading sceneLoadin, Scene menu)
        {
            _level = gym;
            _sceneLoading = sceneLoadin;
            _menu = menu;
        }

        public void Enter()
        {
            
            _sceneLoading.LoadAsync(_level);
            _sceneLoading.LoadAsync(_menu);
        }

        public void Exit()
        {
           
        }

       
    }
}