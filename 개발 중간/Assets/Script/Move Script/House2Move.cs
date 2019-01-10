using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House2Move : MonoBehaviour
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

        if (pPos.x >= -36.81f && pPos.x <= 3.731f && pPos.y <= -107.0f && pPos.y >= -109.0f && Input.GetKeyDown("w"))//1>2층 위로 이동
        {

            player.transform.position = new Vector3(pPos.x, 133.8f, 0f);//좌표
        }

        if (pPos.x >= -36.81f && pPos.x <= 3.731f && pPos.y >= 133.0f && Input.GetKeyDown("s"))//2>1층 아래로 이동
        {

            player.transform.position = new Vector3(pPos.x, -108.2f, 0f);//좌표
        }

        if (pPos.x >= -36.81f && pPos.x <= 3.731f && pPos.y <= -107.0f && Input.GetKeyDown("s"))//1>B1층 아래로 이동
        {

            player.transform.position = new Vector3(pPos.x, -301.8f, 0f);//좌표
        }

        if (pPos.x >= -36.81f && pPos.x <= 3.731f && pPos.y <= -301.0f && Input.GetKeyDown("w"))//B1<1층 위로 이동
        {

            player.transform.position = new Vector3(pPos.x, -108.2f, 0f);//좌표
        }
    }

    void Wall()
    {
        this.player = GameObject.FindGameObjectWithTag("Player");
        Vector3 pPos = this.transform.position;

        if (pPos.y >= -109.0f && pPos.y <= -107.0f) //1층 이동제한
            player.transform.position = new Vector3(Mathf.Clamp(pPos.x, -351.14f, 378.26f), pPos.y, pPos.z);

        if (pPos.y >= 132.0f && pPos.y <= 134.0f) //2층 이동제한
            player.transform.position = new Vector3(Mathf.Clamp(pPos.x, -440.14f, 276.71f), pPos.y, pPos.z);

        if (pPos.y >= -302.0f && pPos.y <= -300.0f) //B1층 이동제한
            player.transform.position = new Vector3(Mathf.Clamp(pPos.x, -74.95f, 239.57f), pPos.y, pPos.z);
    }
}
