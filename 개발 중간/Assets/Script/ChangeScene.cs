using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MapScene() //지도
    {
        SceneManager.LoadScene("MapScene");
    }

    public void HomeScene() //아지트
    {
        SceneManager.LoadScene("HomeScene");
    }

}
