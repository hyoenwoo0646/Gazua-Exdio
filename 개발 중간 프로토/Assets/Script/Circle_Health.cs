using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle_Health : MonoBehaviour {

    public Image 내구도;
    private bool canSlider;
    private float Health;
    private float updateTime;

    // Use this for initialization
    void Start () {
        canSlider = true;
        updateTime = 0.0f;
        Health = 50.0f;
    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
