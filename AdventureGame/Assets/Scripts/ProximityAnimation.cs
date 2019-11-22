using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityAnimation : MonoBehaviour
{
    public Animator anim;
    public Transform proximityObject;
    public int proximityNumber;
    public bool reverseAnimation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (proximityObject)
        {
            float dist = Vector3.Distance(proximityObject.position, transform.position);

            if (dist < proximityNumber)
            {
                anim.SetBool("isClicked", true);
                //Debug.Log("door close"); 
            }
            if ((reverseAnimation == true) && (dist > proximityNumber))
            {
                anim.SetBool("isClicked", false);
                //Debug.Log("door far");
            }
        }
        

    }
}
