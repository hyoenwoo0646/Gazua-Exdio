﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House1Time : MonoBehaviour
{
    int num = 1;
    void Start()
    {
        while(num<=4)
        {
            ManagerClass.instance.Timer();
            num++;
        }
        ManagerClass.instance.Inv();
    }

    void Update()
    {
        
    }
}
