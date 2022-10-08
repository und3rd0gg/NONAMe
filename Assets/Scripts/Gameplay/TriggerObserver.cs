using System;
using Dythervin.AutoAttach;
using UnityEngine;

namespace NONAMe.Gameplay
{
    public class TriggerObserver : MonoBehaviour
    {
        [SerializeField][Attach] private Collider _collider;

        public event Action<Collider> Detected;
        public event Action<Collider> DetectionReleased;

        private void OnTriggerEnter(Collider other)
        {
            Detected?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            DetectionReleased?.Invoke(other);
        }
    }
}
