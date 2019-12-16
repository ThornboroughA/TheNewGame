using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPushScript : MonoBehaviour
{
    public GameObject player;
    private bool isActive;

    private Vector3 force;

    // Start is called before the first frame update
    void Start()
    {
        var body = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {



        transform.Translate(Vector3.forward * Time.deltaTime * 2f);
    }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.transform.CompareTag("Player") && isActive == false)
        //{
        //    player.GetComponent<CharacterController>().enabled = false;
        //    player.GetComponent<Character>().enabled = false;
        //    player.AddComponent<Rigidbody>();
        //    player.AddComponent<BoxCollider>();
        //    var playerBox = player.GetComponent<BoxCollider>();
        //    playerBox.size = new Vector3(2f, 5.7f, 1.5f);
        //    isActive = true;
        //}
    }
    private void OnTriggerExit(Collider other)
    {
        //if (other.transform.CompareTag("Player") && isActive == true)
        //{
        //   Destroy(player.GetComponent<Rigidbody>());
        //    Destroy(player.GetComponent<BoxCollider>());
        //    player.GetComponent<CharacterController>().enabled = true;
        //    player.GetComponent<Character>().enabled = true;
        //    isActive = false;
        //}
    }
}
