using Dythervin.AutoAttach;
using Infrastructure;
using UnityEngine;

namespace Gameplay
{
    public class PlayerInteractor : MonoBehaviour, IInteractor
    {
        [SerializeField] [Attach(Attach.Scene)]
        private Camera _camera;
        [SerializeField][Min(0.1f)] 
        private float _maxInteractionDistance = 1f;

        private InteractionInput _interactionInput;

        private void OnEnable()
        {
            SetupInput();

            void SetupInput()
            {
                _interactionInput = new InteractionInput();
                _interactionInput.Enable();
                _interactionInput.Player.Interact.performed += context => OnInteract();
            }
        }

        private void OnInteract()
        {
            var raycastHits = Physics.RaycastAll(_camera.transform.position,
                _camera.transform.forward * _maxInteractionDistance);

            foreach (var raycastHit in raycastHits)
            {
                if (raycastHit.transform.TryGetComponent(out IInteractable interactable))
                    interactable.Interact(this);
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.magenta;
            var ray = new Ray(_camera.transform.position,
                _camera.transform.forward * _maxInteractionDistance);
            Gizmos.DrawRay(ray);
        }
    }
}