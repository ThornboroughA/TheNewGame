using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character : MonoBehaviour
{
    private Vector3 rotation;

    //character control
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 80f; //newer movement
    private Vector3 moveDirection = Vector3.zero; //older movement
    CharacterController characterController;

    static Animator anim;
   new Vector3 oldPos;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        oldPos = transform.position;
    }
    void FixedUpdate()
    {

        
        //quit game
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }


        //Control
        //if (characterController.isGrounded)
        //{
        //    moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //    moveDirection = moveDirection * moveSpeed;


        //}

        //if (moveDirection != Vector3.zero)
        //    transform.forward = moveDirection * Time.deltaTime;


        //Gravity
        moveDirection.y -= 20f * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);



        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            Forward();
            //anim.SetBool("IsRunning", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            Backward();
            //anim.SetBool("IsRunning", true);
        }


        if (transform.position != oldPos)
        {
            //Debug.Log("T");
            anim.SetBool("isRunning", true);
        }
        else if (transform.position == oldPos)
        {
            //Debug.Log("O");
            anim.SetBool("isRunning", false);
        }
        oldPos = transform.position;

        RaycastHit hit; //code from http://answers.unity.com/answers/1194637/view.html
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }

        //if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        //{
        //    RotateLeft();
        //}
        //else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        //{
        //    RotateRight();
        //}

        

    }



        void Forward()
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        void Backward()
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -moveSpeed);
        }
        void RotateLeft()
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -rotateSpeed);
        }
        void RotateRight()
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }

    }



