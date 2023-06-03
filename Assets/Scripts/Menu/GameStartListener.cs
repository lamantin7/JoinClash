using Touch=Input.Touches.Touch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using StaticContext;
using GameStates.Base;
using GameStates.States;
using Input.Touches;

namespace Menu
{
    public class GameStartListener:MonoBehaviour
    {
        [SerializeField] private InputTouchPanel _startGamePanel;

        private void OnEnable()
        {
            _startGamePanel.Begun += EnterGamePlayState;
            
        }
        private void OnDisable()
        {
            _startGamePanel.Begun -= EnterGamePlayState;
        }

        private void EnterGamePlayState(Touch touch) =>
            Instance<IGameStateMachine>
            .Value
            .Enter<GameplayState>();
    }
}
