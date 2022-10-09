using Dythervin.AutoAttach;
using UnityEngine;

namespace NONAMe.Gameplay
{
    public class PlayerInteractor : MonoBehaviour, IInteractor
    {
        [SerializeField] [Attach(Attach.Scene)]
        private Camera _camera;
        [SerializeField] [Attach] private FirstPersonController _firstPersonController;
        
        [SerializeField][Min(0.1f)] 
        private float _maxInteractionDistance = 1f;


        private void OnEnable()
        {
            _firstPersonController.Interact += OnInteract;
        }

        private void OnDisable()
        {
            _firstPersonController.Interact -= OnInteract;
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