using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollowChar : MonoBehaviour
{
    public Transform cameraObject1;
    public Transform cameraObject2;
    public bool useTransition;
    private bool transition;
    private bool transition2;

    public bool dontSpawnOnChar;
    public bool followCharacter;

    public Vector3 cameraOffset;

    Vector3 targetPos;

    private void Start()
    {
        if (dontSpawnOnChar == false)
        {
            targetPos = cameraObject1.transform.position + cameraOffset;
            transform.position = targetPos;
        }
        if (useTransition)
        {
            StartCoroutine(CamTransitionStart());
        }
    }

    void Update()
    {
        //if (cameraObject && transition == false)
        //{
        //    transform.position = cameraObject.transform.position + new Vector3(x, y, z);
        //}
        //if (useTransition == true)
        //{
        //    StartCoroutine(camTransitionCo());

        //}
        //if (transition == true)
        //{

        //    //x += (target - x) * 0.1f;

        //    //transform.position = transitionObject.transform.position + new Vector3(x, y, z);
        //    //transform.position = Vector3.Lerp(cameraObject.position, (transitionObject.position + new Vector3(x, y, z)), 0.2f);
        //}

        //if (useTransition != true)
        //{
        //    //targetPos = cameraObject.position;
        //}


        if (transition == true)
        {
            Vector3 pos = transform.position;
            pos += (targetPos - pos) * 0.01f;
            transform.position = pos;


            //if (transform.position == transitionObject.position)
            //{
            //    Debug.Log("transition set");
            //    transition = false;
            //}

        }
        else if (transition2 == true)
        {
            transform.position = cameraObject2.position + cameraOffset;
        }
        else if (followCharacter == true)
        {
            transform.position = cameraObject1.position + cameraOffset;
        }
        else
        {
            transform.LookAt(cameraObject1);
        }

    }


    public IEnumerator CamTransitionStart()
    {
        yield return new WaitForSeconds(0.5f);
        targetPos = cameraObject2.transform.position + cameraOffset;
        transition = true;

        yield return new WaitForSeconds(7f);
        transition = false;
        transition2 = true;

        //StartCoroutine(CamTransitionCo());


    }
    //public IEnumerator CamTransitionCo()
    //{
    //    if (transform.position != transitionObject.transform.position + cameraOffset)
    //    {
    //        Vector3 pos = transform.position;
    //        pos += (targetPos - pos) * 0.01f;
    //        transform.position = pos;
    //    }

    //    yield return null;
    //    //yield return new WaitForSeconds(1f);
    //}
}

//egypt cam: dist = 4.
//-4, 4+0.5f, -1