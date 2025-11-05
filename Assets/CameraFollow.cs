using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 100f;
    public Vector3 offset;
    public float maxDistance = 8f; // how far player can get before camera catches up fast

    void LateUpdate()
    {
        Vector3 targetPos = player.position + offset;
        float distance = Vector3.Distance(transform.position, targetPos);

        // If player moves too far, snap instantly
        if (distance > maxDistance)
            transform.position = targetPos;
        else
            transform.position = Vector3.Lerp(transform.position, targetPos, smoothSpeed * Time.deltaTime);
    }
}
