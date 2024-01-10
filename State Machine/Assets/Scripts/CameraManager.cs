using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class CameraManager : MonoBehaviour
    {
        public Transform targetTransform;
        private Vector3 cameraFollowVelocity = Vector3.zero;

        public float cameraFollowSpeed = 0.2f;

        public float lookAngle; //Camera looking up/down
        public float pivotAngle; //Camera looking left/right

        private void Awake()
        {
            targetTransform = FindObjectOfType<Character>().transform;
        }

        public void FollowTarget()
        {
            Vector3 targetPosition = Vector3.SmoothDamp(transform.position, targetTransform.position, ref cameraFollowVelocity, cameraFollowSpeed);

            transform.position = targetPosition;
        }

        public void RotateCamera()
        {
            //lookAngle = lookAngle + (mouseXInput * cameraLookSpeed);
            //pivotAngle = pivotAngle - (mouseYInput * cameraPivotSpeed);
        }
    }
}
