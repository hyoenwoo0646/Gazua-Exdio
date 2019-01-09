using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House1Move : MonoBehaviour
{
    GameObject player;


    void Update()
    {
        Portal();
        Wall();
    }

    void Portal()
    {
        this.player = GameObject.FindGameObjectWithTag("Player");
        Vector3 pPos = this.transform.position;
        if (pPos.x >= -16.0f && pPos.x <= 33.0f && pPos.y <= -93.0f && Input.GetKeyDown("w"))//1>2층 위로 이동
        {

            player.transform.position = new Vector3(pPos.x, 143.1f, 0f);//좌표
        }

        if (pPos.x >= -16.0f && pPos.x <= 33.0f && pPos.y >= 142.0f && Input.GetKeyDown("s"))//2>1층 아래로 이동
        {

            player.transform.position = new Vector3(pPos.x, -94.5f, 0f);//좌표
        }
    }

    void Wall()
    {
        this.player = GameObject.FindGameObjectWithTag("Player");
        Vector3 pPos = this.transform.position;

        if (pPos.y >= -95.0f && pPos.y <= -93.0f) //1층 이동제한
            player.transform.position = new Vector3(Mathf.Clamp(pPos.x, -379.66f, 369.05f), pPos.y, pPos.z);

        if (pPos.y >= 142.0f && pPos.y <= 144.0f) //2층 이동제한
            player.transform.position = new Vector3(Mathf.Clamp(pPos.x, -304.5f, 279.94f), pPos.y, pPos.z);
    }
}
