using GameStates.Base;
using SceneLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GameStates.States
{
    public class GameplayState : IGameState
    {
        private readonly Scene _menu;
        private readonly IAsyncSceneLoading _sceneLoading;

        public GameplayState(Scene menu, IAsyncSceneLoading sceneLoading)
        {
            _menu = menu;
            _sceneLoading = sceneLoading;
        }

        public async void Enter()
        {
            await _sceneLoading.UnloadAsync(_menu);

            Debug.Log("Game Started");
        }

        public void Exit()
        {
           
        }
    }
}
