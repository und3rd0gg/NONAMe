using System;
using UnityEngine;

namespace NONAMe.Gameplay.EnemyAI.Perception
{
    [Serializable]
    public class VisionProfile
    {
        [field: SerializeField]
        [field: Min(10)]
        public float VisionAngle { get; private set; } = 45;

        [field: SerializeField]
        [field: Min(1)]
        public float VisionDistance { get; private set; } = 10;

        [field: SerializeField]
        [field: Min(10)]
        public int Precision { get; private set; } = 10;
        
        [field: SerializeField]
        public Vector3 Offset { get; private set; }
    }
}