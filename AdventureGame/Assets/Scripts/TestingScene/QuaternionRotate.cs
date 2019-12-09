////NEW 1
//using UnityEngine;
//public class QuaternionRotate : MonoBehaviour
//{
//    //code from https://answers.unity.com/questions/1386937/i-want-to-rotate-an-object-towards-mouse-position.html

//    //  e.g. 0.2 = slow, 0.8 = fast, 2 = very fast, Infinity = instant
//    [Tooltip("If rotationSpeed == 0.5, then it takes 2 seconds to spin 180 degrees")]
//    [SerializeField] [Range(0, 10)] float rotationSpeed = 0.5f;


//    [Tooltip("If isInstant == true, then rotationalSpeed == Infinity")]
//    [SerializeField] bool isInstant = false;

//    //Camera _camera = null;  // cached because Camera.main is slow, so we only call it once.
//    void Start()
//    {
//      //  _camera = Camera.main;
//    }


//    void Update()
//    {
//        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//        Quaternion targetRotation = Quaternion.LookRotation(ray.direction);

//            Quaternion currentRotation = transform.rotation;

//            float angularDifference = Quaternion.Angle(currentRotation, targetRotation);
//        // will always be positive (or zero)

//        //if (angularDifference > 0)
//        //{
//        transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, (rotationSpeed * 180 * Time.deltaTime) );/// angularDifference);
//        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
//        //}
//        //else
//        //{
//         //   transform.rotation = targetRotation;
//        //}
//    }
//}


////OLD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionRotate : MonoBehaviour
{
    public Transform target;
    private float speed = 1f;
    private float step = -1f;

    public static Vector3 Point;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 1000)) {
            var localHit = transform.InverseTransformPoint(hit.point);

            var q = Quaternion.LookRotation(localHit - transform.position);//.normalized;

            step = 1f; //speed * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, step);


            //Debug.Log(q);
        }


        ////1 modified
        
        //make q the mouse pointer



        //////1 working
        //var q = Quaternion.LookRotation(target.position - transform.position).normalized;
        ////make q the mouse pointer

        //step = 1f; //speed * Time.deltaTime;
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, q, step);


    }


    ////code from http://answers.unity.com/answers/1194637/view.html
    //RaycastHit hit; 

    //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //    if (Physics.Raycast(ray, out hit, 100))
    //    {
    //        transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));


    //    }
}
