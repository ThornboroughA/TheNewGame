using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideAnimation : MonoBehaviour
{
    private Animator anim;
    public bool startAsOn;

    //public bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        if (startAsOn == true)
        {
            anim.SetBool("isClicked", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            anim.SetBool("isClicked", true);
        }
    }

}
