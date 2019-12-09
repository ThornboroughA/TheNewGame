using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CozinessLightReceiver : MonoBehaviour
{
    new Light light;
    public GameObject characterObject;
    private Character characterScript;
    public int houseCozinessThis;

    public bool lerpCheck;
    float duration = 10f;
    float t = 0f;
    float t2 = 0f;

    public Vector3 colorValues1;
    public Vector3 colorValues2;
    public Vector3 colorValues3;


    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        characterScript = characterObject.GetComponent<Character>();
        //houseCozinessThis = characterScript.houseCoziness;

       


    }

    // Update is called once per frame
    void Update()
    {
        //light.color -= (Color.white / 2f) * Time.deltaTime;

        houseCozinessThis = characterScript.houseCoziness;

        if (lerpCheck == true) {
            
            if (houseCozinessThis > 5)
            {
                if (t < 1)
                {
                    t += 0.01f;
                }
                light.color = Color.Lerp(new Color(colorValues1.x / 255f, colorValues1.y / 255f, colorValues1.z / 255f), new Color(colorValues2.x / 255f, colorValues2.y / 255f, colorValues2.z / 255f), t);
            }
            if (houseCozinessThis > 10)
            {
                if (t2 < 1)
                {
                    t2 += 0.01f;
                }
                light.color = Color.Lerp(new Color(colorValues2.x / 255f, colorValues2.y / 255f, colorValues2.z / 255f), new Color(colorValues3.x / 255f, colorValues3.y / 255f, colorValues3.z / 255f), t2);
            }
        }
        else
        {
            if (houseCozinessThis > 0)
            {
                light.color = new Color(colorValues1.x / 255f, colorValues1.y / 255f, colorValues1.z / 255f);
            }
            if (houseCozinessThis > 5)
            {
                light.color = new Color(colorValues2.x / 255f, colorValues2.y / 255f, colorValues2.z / 255f);
            } 
            if (houseCozinessThis > 10)
            {
                light.color = new Color(colorValues3.x / 255f, colorValues3.y / 255f, colorValues3.z / 255f);
            }
        }
    }
    //update light color only on collision enter so it's not just running constantly
}
