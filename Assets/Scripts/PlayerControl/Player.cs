using Input;
using Interactable;
using System;
using UnityEngine;

namespace PlayerControl
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private InteractableDetector _interactableDetector;
        [SerializeField] private PlayerInputController _input;

        private Action _interactAction;

        private void Awake()
        {
            _interactAction = () => _interactableDetector.CurrentInteractable?.Interact();
        }

        private void OnEnable()
        {
            _input.Interacting += _interactAction;
        }

        private void OnDisable()
        {
            _input.Interacting -= _interactAction;
        }
    }
}
