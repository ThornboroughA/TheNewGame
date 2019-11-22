using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject tool;
    public GameObject tempParent;
    public Transform guide;
    public bool hasTool;

    // Start is called before the first frame update
    void Start()
    {
        tool.GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown() //picks up the object
    {
        if (hasTool == false && Vector3.Distance(transform.position, guide.position) < 12) //so the player has to be close to the object to pick it up
        {
            tool.GetComponent<Rigidbody>().useGravity = false;
            tool.GetComponent<Rigidbody>().isKinematic = true;
            tool.transform.position = guide.transform.position;
            tool.transform.rotation = guide.transform.rotation;
            tool.transform.parent = tempParent.transform;

            hasTool = true;
        }
        else if (hasTool == true)
        {
            tool.GetComponent<Rigidbody>().useGravity = true;
            tool.GetComponent<Rigidbody>().isKinematic = false;
            tool.transform.parent = null;
            tool.transform.position = guide.transform.position;

            hasTool = false;
        }

    }
}
