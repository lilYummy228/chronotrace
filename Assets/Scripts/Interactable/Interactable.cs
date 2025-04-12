using UnityEngine;

namespace Interactable
{
    public abstract class Interactable : MonoBehaviour, IInteractable
    {
        [SerializeField] private Outline _outline;

        public abstract void Interact();

        public void Highlight()
        {
            _outline.enabled = true;
        }

        public void RemoveHighlight()
        {
            _outline.enabled = false;
        }

        public float GetDistanceBetween(Vector3 playerPosition)
        {
            return Vector3.Distance(playerPosition, transform.position);
        }
    }
}
