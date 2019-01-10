using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House2Time : MonoBehaviour
{
    int num = 1;
    void Start() //가정집2 시간흐름
    {
        while (num <= 6)//3시간 소요
        {
            ManagerClass.instance.Timer();
            num++;
        }
        ManagerClass.instance.Inv();
    }
}
