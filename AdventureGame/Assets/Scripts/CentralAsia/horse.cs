

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horse : MonoBehaviour
{
    public GameObject player;
    public GameObject saddle;
    public CharacterController horseController;

    //movement
    private Vector3 moveDirection = Vector3.zero;
    private bool horseActive;

    private float moveSpeed = 3f;
    public float rotateSpeed = 100f;

    public float velocity;
    public float velocityMax = 10.0f;
    public float acceleration;
    public float accelerationSpeed = 0.1f;
    public float accelerationMax = 1.0f;

    private bool sprintActive;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //gravity
        moveDirection.y -= 2f * Time.deltaTime;
        horseController.Move(moveDirection * Time.deltaTime);


        //movement catches
        velocity += acceleration;

        if (velocity < 0) //can't go to negative velocity
        {
            velocity = 0;
        }
        if (velocity > velocityMax) //can't go faster than this speed
        {
            velocity = velocityMax;
        }


        //motion
        transform.Translate(Vector3.forward * Time.deltaTime * velocity);

        //movement
        if (horseActive == true)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
            {
                Forward();
            }
            else if (acceleration > 0)
            {
                acceleration -= (accelerationSpeed * 3);
            }

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                if (sprintActive == false)
                {
                    sprintActive = true;
                    velocityMax *= 2;
                }
            }
            if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.LeftShift))
            {
                velocityMax /= 2;
                sprintActive = false;
            }

            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
            {
                Backward();
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
            {
                RotateLeft();
            }
            else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
            {
                RotateRight();
            }

        }

    }

    private void OnMouseDown()
    {
        player.GetComponent<CharacterController>().enabled = false;
        player.GetComponent<Character>().enabled = false;

        //Debug.Log("horse activate");
        horseController.enabled = true;
        player.transform.position = saddle.transform.position;
        player.transform.parent = transform;
        horseActive = true;

    }
    void Forward()
    {

        if (acceleration > accelerationMax)
        {
            acceleration = accelerationMax;
        }
        else
        {
            acceleration += accelerationSpeed;
        }

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

///
///
//// ITERATION 2   //////
///
///

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class horse : MonoBehaviour
//{
//    public GameObject player;
//    public GameObject saddle;
//    public CharacterController horseController;

//    //movement
//    private Vector3 moveDirection = Vector3.zero;
//    private bool horseActive;
//    private float moveSpeed = 12f;



//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void FixedUpdate()
//    {
//        //gravity
//        moveDirection.y -= 2f * Time.deltaTime;
//        horseController.Move(moveDirection * Time.deltaTime);


//        //movement
//        if (horseActive == true)
//        {
//            //Debug.Log("horse is active");
//            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
//            {
//                Forward();
//                //Debug.Log("forward is pressed");
//            }
//            else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
//            {
//                Backward();
//            }




//            RaycastHit hit; //code from http://answers.unity.com/answers/1194637/view.html
//            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

//            if (Physics.Raycast(ray, out hit, 100))
//            {
//                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
//            }
//        }

//    }

//    private void OnMouseDown()
//    {
//        player.GetComponent<CharacterController>().enabled = false;
//        player.GetComponent<Character>().enabled = false;

//        //Debug.Log("horse activate");
//        horseController.enabled = true;
//        player.transform.position = saddle.transform.position;
//        player.transform.parent = transform;
//        horseActive = true;

//    }
//    void Forward()
//    {

//        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);



//    }
//    void Backward()
//    {
//        transform.Translate(Vector3.forward * Time.deltaTime * -moveSpeed);
//    }
//}


///
///
////ITERATION 1 ////////
///
///




//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class horse : MonoBehaviour
//{
//    public GameObject player;
//    public GameObject saddle;
//    public CharacterController horseController;

//    //movement
//    private Vector3 moveDirection = Vector3.zero;
//    private bool horseActive;
//    private float moveSpeed = 12f;



//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void FixedUpdate()
//    {
//        //gravity
//        moveDirection.y -= 2f * Time.deltaTime;
//        horseController.Move(moveDirection * Time.deltaTime);


//        //movement
//        if (horseActive == true)
//        {
//            Debug.Log("horse is active");
//            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
//            {
//                Forward();
//                Debug.Log("forward is pressed");
//            }
//            else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
//            {
//                Backward();
//            }




//            RaycastHit hit; //code from http://answers.unity.com/answers/1194637/view.html
//            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

//            if (Physics.Raycast(ray, out hit, 100))
//            {
//                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
//            }
//        }

//    }

//    private void OnMouseDown()
//    {
//        player.GetComponent<CharacterController>().enabled = false;
//        player.GetComponent<Character>().enabled = false;

//        Debug.Log("horse activate");
//        horseController.enabled = true;
//        player.transform.position = saddle.transform.position;
//        player.transform.parent = transform;
//        horseActive = true;

//    }
//    void Forward()
//    {

//            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);



//    }
//    void Backward()
//    {
//        transform.Translate(Vector3.forward * Time.deltaTime * -moveSpeed);
//    }
//}
