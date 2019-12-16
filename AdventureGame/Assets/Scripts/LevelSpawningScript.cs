using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawningScript : MonoBehaviour
{
    public string spawnPositionString;
    public Transform bedEmpty;
    public Transform homeMainDoorEmpty;
    public GameObject player;

    private void Awake()
    {
        //spawnPositionString = LevelState.Instance.spawnPositionString;
        //SpawnLocation();
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnPositionString = LevelState.Instance.spawnPositionString;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnPositionString != null)
        {
            StartCoroutine(SpawnLocation());
            
        }
    }

    private IEnumerator SpawnLocation()
    {
        if (spawnPositionString == "bed" && bedEmpty)
        {
            Debug.Log("bed spawn active");
            player.GetComponent<Character>().enabled = false;

            player.transform.position = bedEmpty.position;
            yield return new WaitForSeconds(0.1f);

            player.GetComponent<Character>().enabled = true;

            spawnPositionString = "";
            LevelState.Instance.spawnPositionString = spawnPositionString;
        }
        if (spawnPositionString == "homemain" && homeMainDoorEmpty)
        {
            Debug.Log("main door spawn active");
            player.GetComponent<Character>().enabled = false;

            player.transform.position = homeMainDoorEmpty.position;
            yield return new WaitForSeconds(0.1f);

            player.GetComponent<Character>().enabled = true;

            spawnPositionString = "";
            LevelState.Instance.spawnPositionString = spawnPositionString;
        }
    }
}
