using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ClickSpawner : MonoBehaviour
{

    //mechanics
    public int numberOfHits = 3;
    public int numberSpawn = 1;
    public Transform pickupGuide;
    private bool isHit;

    public bool isActive = true;

    //prefabs
    public GameObject resourceOne;
    public GameObject resourceTwo;
    public GameObject resourceThree;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (numberOfHits <= 0)
        {
            gameObject.SetActive(false);
            //Destroy(gameObject);
            for (int i = 0; i < numberSpawn; i++)
            {
                if (resourceOne)
                {
                    Vector3 randomPosition = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
                    Instantiate(resourceOne, transform.position + randomPosition, transform.rotation);
                }
                if (resourceTwo)
                {
                    Vector3 randomPosition = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
                    Instantiate(resourceTwo, transform.position + randomPosition, transform.rotation);
                }
                if (resourceThree)
                {
                    Vector3 randomPosition = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
                    Instantiate(resourceThree, transform.position + randomPosition, transform.rotation);
                }

                isActive = false;
            }

        }
    }
    private void OnMouseDown()
    {

        if (Vector3.Distance(transform.position, pickupGuide.position) < 12 && numberOfHits > 0) //so the player has to be close to the object
        {
         
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);

            isHit = true;
        }
    }
    private void OnMouseUp()
    {
        if (isHit == true)
        {


            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);

            isHit = false;
            numberOfHits -= 1;
        }

    }

}

