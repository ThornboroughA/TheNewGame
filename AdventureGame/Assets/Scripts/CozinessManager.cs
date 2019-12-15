using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class CozinessManager : MonoBehaviour
{
    public int coziness;


    public GameObject cozinessUI;

    //public GameObject levelStateManager;



    ////POST PROCESSING
    public float initialTemperature;
    public float initialSaturation;
    public float initialContrast;
    public PostProcessVolume colorGradingVolume;
    ColorGrading colorGradingLayer;


  
    

    void Start()
    {
        coziness = LevelState.Instance.coziness;

        ////POST PROCESSING
        colorGradingVolume.profile.TryGetSettings(out colorGradingLayer);
    }

    
    void Update()
    {
        coziness = LevelState.Instance.coziness;

        cozinessUI.GetComponent<Text>().text = "Coziness: " + coziness.ToString();



        //PP values //coziness goes from 0 to 80
        //max =
        //temp 40
        //saturation 40
        //contrast 30

        //min =
        //temp -40
        //saturation -40
        //contrast -10



        ////POST PROCESSING
        //saturation += 1;
        //colorGradingLayer.saturation.value = initialSaturation;

        colorGradingLayer.temperature.value = initialTemperature + coziness;
        colorGradingLayer.saturation.value = initialSaturation + coziness;
        colorGradingLayer.contrast.value = initialContrast + (coziness/2);
    }
    
}
