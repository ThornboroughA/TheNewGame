using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSpawner : MonoBehaviour
{

    public GameObject resourceOne;
    public GameObject resourceTwo;
    public GameObject resourceThree;
    private bool isHit;
    public Transform chestSpawner;
    public Transform pickupGuide;

    ClickAnimation clickScript;

    private bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("3. chestspawner script active");
        clickScript = GetComponent<ClickAnimation>();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {

        //Debug.Log("4. chestspawner mouse down detect");
        if ((clickScript.isActive == true) && (Vector3.Distance(transform.position, pickupGuide.position) < 12))
        {
            int randomInt = Random.Range(0, 3);

            transform.localScale += new Vector3(0.03f, 0.03f, 0.03f);

            if (randomInt == 0)
            {
                Instantiate(resourceOne, chestSpawner.position, transform.rotation);
            }
            else if (randomInt == 1)
            {
                Instantiate(resourceTwo, chestSpawner.position, transform.rotation);
            }
            else if (randomInt == 2)
            {
                Instantiate(resourceThree, chestSpawner.position, transform.rotation);
            }



            isHit = true;
        }
    }
    private void OnMouseUp()
    {
        if (isHit == true)
        {


            transform.localScale -= new Vector3(0.03f, 0.03f, 0.03f);

            isHit = false;
        }

    }
}
