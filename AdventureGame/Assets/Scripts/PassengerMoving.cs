using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassengerMoving : MonoBehaviour
{
    public Transform[] targetPoint;
    public float speed;

    private int current;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(targetPoint[current].position, transform.position);
        //if (transform.position != targetPoint[current].position)
        if (dist > 2)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, targetPoint[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            Debug.Log("target 1 hit");
            current = (current + 1) % targetPoint.Length;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
