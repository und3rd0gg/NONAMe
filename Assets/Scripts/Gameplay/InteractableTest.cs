using Infrastructure;
using UnityEngine;

namespace Gameplay
{
    public class InteractableTest : MonoBehaviour, IInteractable
    {
        public bool CanInteract { get; }
        
        public void Interact(object sender)
        {
            Debug.Log("VAR");
        }
    }
}