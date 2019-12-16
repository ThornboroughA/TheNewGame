using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    public bool collisionDeath;
    public GameObject player;

    private string spawnPositionString;
    private int coziness;

    public GameObject blackScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (collisionDeath == true && other.transform.CompareTag("Player"))
        {
            StartCoroutine(death());
        }
    }

    //private void death()
    //{
    //    //alphaFadeValue = Mathf.Clamp01(alphaFadeValue - (Time.deltaTime / 3f));

    //    blackScreen.SetActive(true);

    //    Debug.Log("death");
        
    //}
    private IEnumerator death()
    {
        
        yield return new WaitForSeconds(0.5f);
        player.GetComponent<Character>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        //play death animation
        coziness = LevelState.Instance.coziness;
        coziness -= 5;
        LevelState.Instance.coziness = coziness;


        yield return new WaitForSeconds(1f);
        blackScreen.SetActive(true);
        spawnPositionString = "bed";

        yield return new WaitForSeconds(1.5f);

        LevelState.Instance.spawnPositionString = spawnPositionString;
        SceneManager.LoadScene("Home", LoadSceneMode.Single);
    }
}
