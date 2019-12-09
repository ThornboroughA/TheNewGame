using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CozinessAdjust : MonoBehaviour
{
    public int houseCozinessThis;
    public GameObject characterObject;
    private Character characterScript;

    private bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        characterScript = characterObject.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (isActive == false)
        {
            houseCozinessThis = characterScript.houseCoziness;
            Debug.Log(houseCozinessThis);
            characterScript.houseCoziness += 1;

            isActive = true;
        }
        



    }
}
