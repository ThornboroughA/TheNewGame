using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMain : MonoBehaviour
{
    public GameObject lastText;
    public GameObject currentText;
    public GameObject nextText;

    public bool startAfterDelay;

    //public string tileToCheck;
    //private string tileData;

    public float delayOne;
    public float delayTwo;
    public float delayThree;

    // Start is called before the first frame update
    void Start()
    {
        if (startAfterDelay == true)
        {
            StartCoroutine(text1Co());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (tileToCheck != "")
        //{
        //    tileData = LevelState.Instance.completedTiles;

        //    if (tileData.Contains(tileToCheck))
        //    {
        //        StartCoroutine(TileCompleteCo());
        //        Debug.Log("tile check match");
        //    }
        //}
        
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(text1Co());

    }

    private IEnumerator text1Co()
    {
        yield return new WaitForSeconds(delayOne);
        if (lastText)
        {
            lastText.SetActive(false);
        }

        yield return new WaitForSeconds(delayTwo);

        if (currentText)
        {
            currentText.SetActive(true);
        }
        
    }
    //private IEnumerator TileCompleteCo()
    //{
    //    yield return new WaitForSeconds(delayOne);
    //    if (lastText)
    //    {
    //        lastText.SetActive(false);
    //    }
    //    yield return new WaitForSeconds(delayTwo);
    //    if (currentText)
    //    {
    //        currentText.SetActive(true);
    //    }
    //}

}
