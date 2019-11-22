using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollowChar : MonoBehaviour
{
    public Transform playerObject;
    public float distanceFromObject;
    void FixedUpdate()
    {

        transform.position = playerObject.transform.position + new Vector3(-distanceFromObject, (distanceFromObject + 0.5f), -1);
        
    }
}