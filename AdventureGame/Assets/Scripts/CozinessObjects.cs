using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CozinessObjects : MonoBehaviour
{
    public GameObject tier1;
    public GameObject tier2;

    public GameObject characterObject;
    private Character characterScript;
    public int houseCozinessThis;

    // Start is called before the first frame update
    void Start()
    {
        characterScript = characterObject.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        houseCozinessThis = characterScript.houseCoziness;

        if (houseCozinessThis > 5)
        {
            tier1.SetActive(true);
        }
        if (houseCozinessThis > 10)
        {
            tier2.SetActive(true);
        }
        
    }
}
