using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerClass : MonoBehaviour
{
    static ManagerClass current = null;
    static GameObject container = null;

    public static ManagerClass Instance
    {
        get
        {
            if(current == null)
            {
                container = new GameObject();
                container.name = "Singleton";
                current = container.AddComponent(typeof(ManagerClass)) as ManagerClass;
                DontDestroyOnLoad(current);
            }
            return current;
        }
    }


    static float min = 0f;
    static float hour = 0f;

    public void Inv()
    {
        InvokeRepeating("Timer", 1.0f, 5.0f);
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
