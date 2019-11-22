using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript_inside : MonoBehaviour
{

    public GameObject text1;
    public GameObject text2;

    public BoxCollider collider1;

    private bool noRepeats;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(text1Coroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (noRepeats == false)
        {
            StartCoroutine(text2Coroutine());
            noRepeats = true;
        }
        
    }
    private IEnumerator text1Coroutine()
    {
        yield return new WaitForSeconds(2.5f);
        text1.SetActive(true);
    }
    private IEnumerator text2Coroutine()
    {
        yield return new WaitForSeconds(2f);
        text2.SetActive(true);
        yield return new WaitForSeconds(2f);
        text1.SetActive(false);
        yield return new WaitForSeconds(2f);
        text2.GetComponent<TMPro.TextMeshPro>().text = "";
        yield return new WaitForSeconds(1f);
        text2.GetComponent<TMPro.TextMeshPro>().text = "so bountiful";
        yield return new WaitForSeconds(4f);
        text2.GetComponent<TMPro.TextMeshPro>().text = "";
        yield return new WaitForSeconds(1f);
        text2.GetComponent<TMPro.TextMeshPro>().text = "but I also found I had no idea what anything was.";

    }


}
