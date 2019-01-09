using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle_Happy : MonoBehaviour {

    public Image 행복도;
    private bool canSlider;
    private float HappyTime;
    private float updateTime;

    // Use this for initialization
    void Start () {
        canSlider = true;
        updateTime = 0.0f;
        HappyTime = 50.0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (canSlider)
        {
            updateTime = updateTime + Time.deltaTime;
            행복도.fillAmount = 1.0f - (Mathf.SmoothStep(0, 100, updateTime / HappyTime) / 100);

            if (updateTime > HappyTime)
            {
                행복도.fillAmount = 0.0f;
                updateTime = 0.0f;
                canSlider = false;
            }
        }
    }
}
