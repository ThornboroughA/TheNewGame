using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EgyptToAmherst : MonoBehaviour
{
    public bool missionAccomplished;
    private bool coroutineBool;

    float t = 0f;
    //private float yField = 1f;

    public MeshRenderer groundRenderer;
    public GameObject egyptGroup;
    public GameObject amherstGroup;

    public GameObject torchFlame;
    public GameObject torchBody;

    public GameObject text1;
    public GameObject text2;

    public Transform player;

    public string tileID;
    public string completedTiles;

    public int coziness;


    // Start is called before the first frame update
    void Start()
    {

        coziness = LevelState.Instance.coziness;
        completedTiles = LevelState.Instance.completedTiles;
        if (completedTiles.Contains(tileID))
        {
            egyptGroup.SetActive(false);
            amherstGroup.SetActive(true);
            torchBody.SetActive(false);
            groundRenderer.material.color = new Color(80 / 255f, 100 / 255f, 60 / 255f);

            if (text1)
            {
                text1.SetActive(false);
            }
        }

        //read from levelstate.tileIDList whether (this script's) tileID is in it; then spawn in Amherst stuff based on that
    }

    // Update is called once per frame
    void Update()
    {



        if (missionAccomplished == true)
        {
            StartCoroutine(ActivationRoutine());
            completedTiles = LevelState.Instance.completedTiles;
        }



        if (coroutineBool == true)
        {


            if (t < 1)
            {
                t += 0.005f;
            }
                //yField -= 0.005f;

                groundRenderer.material.color = Color.Lerp(new Color(210 / 255f, 185 / 255f, 130 / 255f), new Color(80 / 255f, 100 / 255f, 60 / 255f), t);
                

                egyptGroup.transform.localScale = new Vector3(1, (1 - t), 1);
                amherstGroup.transform.localScale = new Vector3(1, t, 1);

                Debug.Log(t);
                Debug.Log(coroutineBool);
            
        }


        if (Input.GetKey("p")) {
            missionAccomplished = true;
        }
    }
    private void OnMouseDown()
    {
        if (Vector3.Distance(transform.position, player.position) < 5f)
        {

            torchFlame.SetActive(true);
            missionAccomplished = true;
        }
    }
    private IEnumerator ActivationRoutine()
    {
        yield return new WaitForSeconds(3f);

        coroutineBool = true;

        yield return new WaitForSeconds(0.5f);

        if (torchBody)
        {
            torchBody.SetActive(false);
        }
        if (torchFlame)
        {
            torchFlame.SetActive(false);
        }
        if (text1)
        {
            text1.SetActive(false);
        }
        
        amherstGroup.SetActive(true);

        yield return new WaitForSeconds(5f);

        if (egyptGroup)
        {
            egyptGroup.SetActive(false);
        }

        if (completedTiles.Contains(tileID))
        {
            
        }
        else
        {
            completedTiles += tileID;
            LevelState.Instance.completedTiles = completedTiles; //this was adding repeatedly for some reason
            coziness += 20;
            LevelState.Instance.coziness = coziness;
        }

        yield return new WaitForSeconds(1f);
        if (text2)
        {
            text2.SetActive(true);
        }
            
    }


}
