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
    private float moveSpeed = 12f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //gravity
        moveDirection.y -= 2f * Time.deltaTime;
        horseController.Move(moveDirection * Time.deltaTime);


        //movement
        if (horseActive == true)
        {
            Debug.Log("horse is active");
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
            {
                Forward();
                Debug.Log("forward is pressed");
            }
            else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
            {
                Backward();
            }




            RaycastHit hit; //code from http://answers.unity.com/answers/1194637/view.html
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100))
            {
                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            }
        }

    }

    private void OnMouseDown()
    {
        player.GetComponent<CharacterController>().enabled = false;
        player.GetComponent<Character>().enabled = false;

        Debug.Log("horse activate");
        horseController.enabled = true;
        player.transform.position = saddle.transform.position;
        player.transform.parent = transform;
        horseActive = true;

    }
    void Forward()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);



    }
    void Backward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * -moveSpeed);
    }
}



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
