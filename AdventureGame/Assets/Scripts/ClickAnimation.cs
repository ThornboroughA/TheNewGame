using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnimation : MonoBehaviour
{
    //static Animator anim;
    public Animator anim;
    public GameObject effectItem;
    public float timeToWait = 1;

    public bool isActive;





    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        anim.SetBool("isClicked", true);
        Debug.Log("1. " + anim + "click collider triggered");

        StartCoroutine(EffectItemCall());
    }

    public IEnumerator EffectItemCall()
    {
        yield return new WaitForSeconds(timeToWait);
        if (effectItem)
        {
            effectItem.SetActive(true);
        }
       // Debug.Log("2. " + "is active");
        isActive = true;
    }

}

