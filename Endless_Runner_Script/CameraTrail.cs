using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrail : MonoBehaviour
{
    public Transform target;
    public float CameraDistance = 5.0f;
    public float CameraHeight = 3.0f;
    public float cameraRotation = 0.02f;

    // Update is called once per frame
    void Update()
    {
        Vector3 followPos = target.position - target.forward * CameraDistance;

        followPos.y += CameraHeight;
        transform.position += (followPos - transform.position) * cameraRotation;

        transform.LookAt(target.transform);
    }
}