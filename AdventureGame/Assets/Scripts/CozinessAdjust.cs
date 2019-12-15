using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CozinessAdjust : MonoBehaviour
{
    public int houseCozinessThis;
    //public GameObject cozyManager;
    //CozinessManager CozinessManager;
    //LevelState levelState;
    //public GameObject levelStateObject;
 

    private bool isActive;
    public bool onlyOnce;

    // Start is called before the first frame update
    void Start()
    {
        //CozinessManager = cozyManager.GetComponent<CozinessManager>();
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (onlyOnce == true)
        {
            if (isActive == false)
            {
                //houseCozinessThis = CozinessManager.coziness;
                //Debug.Log(houseCozinessThis);
                //CozinessManager.coziness += 1;



                isActive = true;
            }
        }
        else
        {
            //houseCozinessThis = CozinessManager.coziness;
            //Debug.Log(houseCozinessThis);
            //CozinessManager.coziness += 1;

            houseCozinessThis = LevelState.Instance.coziness;
            houseCozinessThis++;
            LevelState.Instance.coziness = houseCozinessThis;

        }



    }
}
