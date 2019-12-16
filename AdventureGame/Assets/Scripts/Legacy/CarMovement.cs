using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 20f;
    public float rotateSpeed = 80f;
    public Transform playerTransform;
    private Vector3 initialLocation;


    private bool newBool = false;
    AudioSource honkSound;


    // Start is called before the first frame update
    void Start()
    {
        initialLocation = transform.position;

        honkSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform)
        {
            float dist = Vector3.Distance(playerTransform.position, transform.position);


            //Debug.Log(newBool);
            if (dist < 12f)
            {
                newBool = true;
            }
            else if (dist > 12f)
            {
                newBool = false;
            }

            if (newBool == true)
            {
                honkSound.Play(0);
            } else if (newBool == false)
            {

               //honkSound.Stop();
            }

            if (transform.position.z > -30 && newBool == false)
            {
                //Debug.Log("not close");
                transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
                //StartCoroutine(CarTurn());
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("car collider entered");
        honkSound.Play(0);

    }
    //private IEnumerator CarTurn()
    //{
    //    yield return new WaitForSeconds(1f);

    //    transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
    //    transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

    //}

}
