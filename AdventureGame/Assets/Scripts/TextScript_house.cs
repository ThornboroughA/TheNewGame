using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript_house : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("active");
        StartCoroutine(routine1());
    }

    // Update is called once per frame
    void Update()
    {

    }



    private IEnumerator routine1()
    {
        Debug.Log("routine active");
        yield return new WaitForSeconds(1f);
        text1.SetActive(true);
        yield return new WaitForSeconds(4f);
        text1.GetComponent<TMPro.TextMeshPro>().text = "";
        yield return new WaitForSeconds(1f);
        text1.GetComponent<TMPro.TextMeshPro>().text = "but I forgot my red car toy!";
        yield return new WaitForSeconds(2f);
        text1.SetActive(false);
        yield return new WaitForSeconds(1f);
        text2.SetActive(true);
    }

}

//The flight's tomorrow and I'm all packed
//but I forgot my red car toy!