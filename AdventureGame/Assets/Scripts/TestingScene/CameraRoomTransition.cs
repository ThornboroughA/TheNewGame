using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRoomTransition : MonoBehaviour
{
    public GameObject sceneCamera;
    public GameObject rotationEmpty;
    private Vector3 transitionPos;
   

    private bool transitionBool;
  

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Transform>(sceneCamera);
    }

    // Update is called once per frame
    void Update()
    {
        if (transitionBool == true)
        {
            transitionPos = (sceneCamera.transform.position - rotationEmpty.transform.position) * 0.01f;
            sceneCamera.transform.position -= transitionPos;

            //transitionRot = (sceneCamera.transform.rotation - rotationEmpty.transform.rotation) * 0.01f;

            //Debug.Log(transitionBool);
        }
        if (sceneCamera.transform.position.normalized == rotationEmpty.transform.position.normalized)
        {
            transitionBool = false;
            //Debug.Log("transition has stopped");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (sceneCamera && rotationEmpty)
        {
            transitionBool = true;
        }
        else
        {
            Debug.Log("assign camera and or rotationEmpty");
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        transitionBool = false;
        //Debug.Log(rotationEmpty + "collider exit");
    }


   
}

//add public vector3 that gets updated with each room collider the character enters
//camera then transitions to that vector3