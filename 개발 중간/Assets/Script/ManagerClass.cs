using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerClass : MonoBehaviour
{
    public static ManagerClass instance;
    public void Awake()
    {
        ManagerClass.instance = this;
    }


    static float min = 0f;
    static float hour = 0f;

    public void Inv()
    {
        InvokeRepeating("Timer", 5.0f, 5.0f);
    }

    public void Timer()
    {
        min += 30;
        if(min == 60)
        {
            min = 0f;
            hour += 1;
        }

        if(hour == 24)
        {
            hour = 0f;
        }
        Debug.Log(hour);
        Debug.Log(min);   
    }
}
