using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    private Vector3 cameraPositionOffset;
    [Range(0.01f, 1.0f)] public float smoothFactor = 0.5f;

    private bool lookAtPlayer = false;
    private Vector3 cameraElevationOffset = new Vector3 (0,1.5f,0);

    private bool rotateAroundPlayer = true;
    private float rotationSpeed = 1.0f;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        cameraPositionOffset = transform.position - playerTransform.position;
    }

    private void LateUpdate() {
        if(rotateAroundPlayer){
            Quaternion cameraTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);
            cameraPositionOffset = cameraTurnAngle * cameraPositionOffset;
        }

        Vector3 newPos = playerTransform.position + cameraPositionOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);

        if(lookAtPlayer || rotateAroundPlayer){
            transform.LookAt(playerTransform.position + cameraElevationOffset);
        }
    }
}
