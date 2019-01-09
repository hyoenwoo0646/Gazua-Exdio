using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle_Timelimit : MonoBehaviour
{

    public Image 전력량;
    private bool canSlider;
    private float EnergyTime;
    private float updateTime;


    // Use this for initialization
    void Start()
    {
        canSlider = true;
        updateTime = 0.0f;
        EnergyTime = 50.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (canSlider)
        {
            updateTime = updateTime + Time.deltaTime;
            전력량.fillAmount = 1.0f - (Mathf.SmoothStep(0, 100, updateTime / EnergyTime) / 100);

            if (updateTime > EnergyTime)
            {
                전력량.fillAmount = 0.0f;
                updateTime = 0.0f;
                canSlider = false;
            }
        }
    }
}
