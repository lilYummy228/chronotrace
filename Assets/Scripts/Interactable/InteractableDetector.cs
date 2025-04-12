using UnityEngine;

namespace Interactable
{
    public class InteractableDetector : MonoBehaviour
    {
        private Interactable _activeInteractable = null;

        public IInteractable CurrentInteractable => _activeInteractable;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Interactable interactable))
            {
                if (_activeInteractable != null)
                    _activeInteractable.RemoveHighlight();

                _activeInteractable = interactable;
                _activeInteractable.Highlight();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out Interactable interactable))
            {
                if (_activeInteractable == interactable)
                {
                    _activeInteractable.RemoveHighlight();
                    _activeInteractable = null;
                }
            }
        }
    }
}
