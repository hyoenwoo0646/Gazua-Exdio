using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerClass : MonoBehaviour
{
    public static ManagerClass instance;
    public void Awake()   //싱글톤
    {
        ManagerClass.instance = this;
    }


    static float min = 0f;
    static float hour = 0f;

    public void Inv()  //시간 함수 반복 실행
    {
        InvokeRepeating("Timer", 5.0f, 5.0f);
    }

    public void Timer()   //5초당 30분
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

    public void ReStart()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Single);
    }
}
