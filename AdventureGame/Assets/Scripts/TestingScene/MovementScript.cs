using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code from answer to: https://answers.unity.com/questions/578443/jumping-with-character-controller.html

public class MovementScript : MonoBehaviour
{
    //movement
    private float speed = 6.0f;
    private float jumpSpeed = 10f;
    private float gravity = 25f;
    private Vector3 moveDirection;
    private float speedVertical;
    

    //rotation
    private float traverseSpeed = 360f;

    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        


        if (controller.isGrounded)
        {
            speedVertical = -1f;
            if (Input.GetButtonDown ("Jump"))
            {
                speedVertical = jumpSpeed;
            }
        }

        speedVertical -= gravity * Time.deltaTime;

        moveDirection.y = speedVertical;

        controller.Move(moveDirection * Time.deltaTime);

        //rotation
        RaycastHit hit; //code from http://answers.unity.com/answers/1194637/view.html

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));

            
        }

        //Debug.Log(hit.point.z);
    }
}
