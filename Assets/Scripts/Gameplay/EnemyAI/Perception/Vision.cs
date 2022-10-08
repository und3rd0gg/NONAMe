using System;
using System.Collections.Generic;
using UnityEngine;

namespace NONAMe.Gameplay.EnemyAI.Perception
{
    public class Vision : MonoBehaviour
    {
        [SerializeField] private VisionProfile _visionProfile;
        
        private List<IDetectable> _detectedObjects;

        public event Action<IDetectable> ObjectDetected;

        private void FixedUpdate()
        {
            Scan();
        }

        private IDetectable DetectWithRaycast(Vector3 dir)
        {
            var pos = transform.position + _visionProfile.Offset;

            if (Physics.Raycast(pos, dir, out var hit, _visionProfile.VisionDistance))
            {
                if (hit.transform.TryGetComponent(out IDetectable detected))
                {
                    Debug.DrawLine(pos, hit.point, Color.blue);
                    return detected;
                }
            }

            Debug.DrawRay(pos, dir * _visionProfile.VisionDistance, Color.red);
            return null;
        }

        private void Scan()
        {
            _detectedObjects = new List<IDetectable>(10);
            float j = 0;
            for (var i = 0; i < _visionProfile.Precision; i++)
            {
                var x = Mathf.Sin(j);
                var y = Mathf.Cos(j);

                j += _visionProfile.VisionAngle * Mathf.Deg2Rad / _visionProfile.Precision;

                var dir = transform.TransformDirection(new Vector3(x, 0, y));
                IDetectable detectedObject;
                detectedObject = DetectWithRaycast(dir);

                if (x != 0)
                {
                    dir = transform.TransformDirection(new Vector3(-x, 0, y));
                    detectedObject = DetectWithRaycast(dir);
                }

                if (!_detectedObjects.Contains(detectedObject) && detectedObject != null)
                {
                    ObjectDetected?.Invoke(detectedObject);
                    _detectedObjects.Add(detectedObject);
                }
            }
        }
    }
}