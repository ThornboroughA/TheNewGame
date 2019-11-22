using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : MonoBehaviour
{

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;

    public BoxCollider text2Collider;

    public GameObject rubble1;
    private bool rubble1Bool = true;
    ClickSpawner clickSpawner1;

    public GameObject rubble2;
    private bool rubble2Bool = true;
    ClickSpawner clickSpawner2;

    public GameObject chest1;
    private bool chest1Bool;
    ClickAnimation clickAnimation1;

    public GameObject door1;
    private bool door1Bool;
    ClickAnimation clickAnimation2;

    private bool co2;
    private bool co3;
    private bool co4;
    private bool co5;
    private bool co6;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("textscript start");
        StartCoroutine(text1Co());
        
        clickSpawner1 = rubble1.GetComponent<ClickSpawner>();

        clickSpawner2 = rubble2.GetComponent<ClickSpawner>();

        clickAnimation1 = chest1.GetComponent<ClickAnimation>();

        clickAnimation2 = door1.GetComponent<ClickAnimation>();

    }
    void Update()
    {
        rubble1Bool = clickSpawner1.isActive;
        rubble2Bool = clickSpawner2.isActive;
        chest1Bool = clickAnimation1.isActive;
        door1Bool = clickAnimation2.isActive;

        if (rubble1Bool == false && co3 == false )
        {
            StartCoroutine(text3Co());
        }
        if (rubble2Bool == false && co4 == false)
        {
            StartCoroutine(text4Co());
            
        }
        if (chest1Bool == true && co5 == false)
        {
            StartCoroutine(text5Co());
        }
        if (door1Bool == true && co6 == false)
        {
            StartCoroutine(text6Co());
        }


    }

    private IEnumerator text1Co()
    {
        yield return new WaitForSeconds(1.5f);
        text1.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (co2 == false)
        {
            text1.SetActive(false);
            StartCoroutine(text2Co());
        }
    }

    private IEnumerator text2Co()
    {
        co2 = true;
        yield return new WaitForSeconds(1.5f);
        text2.SetActive(true);
    }
    private IEnumerator text3Co()
    {
        co3 = true;
        yield return new WaitForSeconds(1f);
        text2.GetComponent<TMPro.TextMeshPro>().text = "";
        yield return new WaitForSeconds(1f);
        text2.GetComponent<TMPro.TextMeshPro>().text = ".";
        yield return new WaitForSeconds(1f);
        text2.GetComponent<TMPro.TextMeshPro>().text = "..";
        yield return new WaitForSeconds(1f);
        text2.GetComponent<TMPro.TextMeshPro>().text = "...";
        yield return new WaitForSeconds(1f);
        text2.GetComponent<TMPro.TextMeshPro>().text = "... nope.";
        yield return new WaitForSeconds(2f);
        text2.SetActive(false);
        yield return new WaitForSeconds(1f);
        text3.SetActive(true);

    }
    private IEnumerator text4Co()
    {
        co4 = true;
        yield return new WaitForSeconds(1f);
        text3.SetActive(false);
        yield return new WaitForSeconds(1f);
        text4.SetActive(true);
        yield return new WaitForSeconds(2f);
        text4.GetComponent<TMPro.TextMeshPro>().text = "";
        yield return new WaitForSeconds(1f);
        text4.GetComponent<TMPro.TextMeshPro>().text = "just more laundry.";
        yield return new WaitForSeconds(4f);
        text4.SetActive(false);
        yield return new WaitForSeconds(1f);
        text5.SetActive(true);
        yield return new WaitForSeconds(2f);
        text5.SetActive(false);
        yield return new WaitForSeconds(2f);
        text6.SetActive(true);
    }
    private IEnumerator text5Co()
    {
        co5 = true;
        yield return new WaitForSeconds(3f);
        text6.GetComponent<TMPro.TextMeshPro>().text = "";
        yield return new WaitForSeconds(3f);
        text6.GetComponent<TMPro.TextMeshPro>().text = "are you kidding me.";
        yield return new WaitForSeconds(3f);
        text6.GetComponent<TMPro.TextMeshPro>().text = "";
        yield return new WaitForSeconds(1.5f);
        text6.GetComponent<TMPro.TextMeshPro>().text = "wait.";
        yield return new WaitForSeconds(2f);
        text6.GetComponent<TMPro.TextMeshPro>().text = "didn't I leave it by the door?";
    }
    private IEnumerator text6Co()
    {
        co6 = true;
        yield return new WaitForSeconds(3f);
        text7.SetActive(true);
    }
}
