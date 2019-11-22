using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollowChar : MonoBehaviour
{
    public Transform playerObject;
    public float x;
    public float y;
    public float z;
    void FixedUpdate()
    {
        if (playerObject)
        {
            transform.position = playerObject.transform.position + new Vector3(x, y, z);
        }
        
        
    }
}

//egypt cam: dist = 4.
//-4, 4+0.5f, -1