using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnimation : MonoBehaviour
{
    //static Animator anim;
    private Animator anim;
    public GameObject effectItem;
    public float timeToWait = 1;

    public bool isActive;

    public float distance;
    public Transform player;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
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

    public IEnumerator EffectItemCall()
    {
        yield return new WaitForSeconds(timeToWait);
        if (effectItem)
        {
            effectItem.SetActive(true);
        }
        isActive = true;
    }

}

