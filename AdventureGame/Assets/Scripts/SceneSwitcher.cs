using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string sceneString;


    private Animator anim;
    public float distance;
    public Transform player;
    public bool collideEnter;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (distance > 0)
        {
            if (Vector3.Distance(transform.position, player.position) < distance)
            {
                anim.SetBool("isClicked", true);
                Debug.Log("1. " + anim + "click collider triggered");

                StartCoroutine(EffectItemCall());
            }
        }
        else
        {
            anim.SetBool("isClicked", true);
            Debug.Log("1. " + anim + "click collider triggered");

            StartCoroutine(EffectItemCall());
        }




    }
    private void OnTriggerEnter(Collider other)
    {
        if (collideEnter == true)
        {
            SceneManager.LoadScene(sceneString, LoadSceneMode.Single);
        }
        

    }

    public IEnumerator EffectItemCall()
    {
        yield return new WaitForSeconds(1.75f);
        SceneManager.LoadScene(sceneString, LoadSceneMode.Single);

    }
}
