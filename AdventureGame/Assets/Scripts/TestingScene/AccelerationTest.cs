using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationTest : MonoBehaviour
{

    //acceleration and movement
    public float moveSpeed = 3f;
    public float rotateSpeed = 100f;

    public float velocity;
    public float velocityMax = 20.0f;
    public float acceleration;
    public float accelerationSpeed = 0.1f;
    public float accelerationMax = 1.0f;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ////JUMPING

        


        ////JUMPING END

        ////ACCELERATION AND MOVEMENT
        //acceleration criteria

        if (velocity > 0)
        {
            Debug.Log("velocity " + velocity);
        }
        if (acceleration > 0)
        {
            Debug.Log("acceleration " + acceleration);
        }
        
        
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

        //movement inputs
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            Forward();
        }
        else if (acceleration > 0)
        {
            acceleration -= (accelerationSpeed * 3);
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
        ////ACCELERATION AND MOVEMENT END
       
    }


    void Jump()
    {


    }
    void Forward()
    {
        //if (acceleration < accelerationMax)
        //{
            
        if (acceleration > accelerationMax)
        {
            acceleration = accelerationMax;
        }
        else
        {
            acceleration += accelerationSpeed;
        }
        //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * acceleration);
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



//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class AccelerationTest : MonoBehaviour
//{
//    public float moveSpeed = 3f;
//    public float rotateSpeed = 100f;

//    public float velocity;
//    public float velocityMax = 20.0f;
//    public float acceleration;
//    public float accelerationSpeed = 0.1f;
//    public float accelerationMax = 1.0f;
    


//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //acceleration criteria

        
        
//        velocity += acceleration;

//        if (velocity < 0)
//        {
//            velocity = 0;
//        }
//        if (velocity > velocityMax)
//        {
//            velocity = velocityMax;
//        }


//        //motion
//        transform.Translate(Vector3.forward * Time.deltaTime * velocity);

//        //movement inputs
//        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
//        {
//            Forward();
//        }
//        else if (acceleration > 0)
//        {
//            acceleration -= (accelerationSpeed * 3);
//        }




//        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
//        {
//            Backward();
//        }
//        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
//        {
//            RotateLeft();
//        }
//        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
//        {
//            RotateRight();
//        }

       
//    }

//    void Forward()
//    {
//        //if (acceleration < accelerationMax)
//        //{
//            Debug.Log(velocity);
//        if (acceleration > accelerationMax)
//        {
//            acceleration = accelerationMax;
//        }
//        else
//        {
//            acceleration += accelerationSpeed;
//        }

            
//        //}
        

//        //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * acceleration);
//    }
//    void Backward()
//    {
//        transform.Translate(Vector3.forward * Time.deltaTime * -moveSpeed);
//    }
//    void RotateLeft()
//    {
//        transform.Rotate(Vector3.up * Time.deltaTime * -rotateSpeed);
//    }
//    void RotateRight()
//    {
//        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
//    }
//}
