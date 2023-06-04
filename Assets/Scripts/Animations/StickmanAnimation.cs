using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animations
{
    public class StickmanAnimation : MonoBehaviour
    {
        private static readonly int IsRunning = Animator.StringToHash("IsRunning");
        private Animator _animator;
        void Start() => _animator = GetComponent<Animator>();

        [ContextMenu(nameof(EnterRunState))]
        private void EnterRunState()
        {
            _animator.SetBool(IsRunning, true);
        }

    }
}