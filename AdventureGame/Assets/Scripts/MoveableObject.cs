using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    //Variables
    //public GameObject item; 
    GameObject tempParent; 
    
    public int pickupDistance;


    void Start()
    {
        Debug.Log("moveable object start");
        tempParent = GameObject.FindWithTag("pickupGuide");
       //guide = GameObject.FindWithTag("pickupGuide").transform;
        GetComponent<Rigidbody>().useGravity = true;
    }

    private void OnMouseDown() //picks up the object
    {
        
        if (Vector3.Distance(transform.position, tempParent.transform.position) < pickupDistance) //so the player has to be close to the object to pick it up
        {
            Debug.Log("movable object distance");
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;
            transform.position = tempParent.transform.transform.position;
            transform.rotation = tempParent.transform.transform.rotation;
            transform.parent = tempParent.transform;
        }
        
    }
    private void OnMouseUp() //drops the object
    {
        if (Vector3.Distance(transform.position, tempParent.transform.position) < pickupDistance)
        {
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            transform.position = tempParent.transform.transform.position;
        }
    }
}
