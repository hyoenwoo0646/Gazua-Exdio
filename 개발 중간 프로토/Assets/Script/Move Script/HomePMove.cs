using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePMove : MonoBehaviour
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
        if (pPos.x >= -293 && pPos.x <= -243 && pPos.y <= -91.0f && Input.GetKeyDown("w"))//1>2층 위로 이동
        {

            player.transform.position = new Vector3(pPos.x, 147.0f, 0f);//좌표
        }

        if (pPos.x >= -293 && pPos.x <= -243 && pPos.y >= 146.0f && Input.GetKeyDown("s"))//2>1층 아래로 이동
        {

            player.transform.position = new Vector3(pPos.x, -93.2f, 0f);//좌표
        }
        if (pPos.x >= -293 && pPos.x <= -243 && pPos.y <= -91.0f && pPos.y >= -94.0f && Input.GetKeyDown("s"))//1>B1층 아래로 이동
        {

            player.transform.position = new Vector3(pPos.x, -291.5f, 0f);//좌표
        }
        if (pPos.x >= -293 && pPos.x <= -243 && pPos.y <= -290.0f && Input.GetKeyDown("w"))//B1>1층 위로 이동
        {
            
            player.transform.position = new Vector3(pPos.x, -93.2f, 0f);//좌표
        }
    }

    void Wall()
    {
        this.player = GameObject.FindGameObjectWithTag("Player");
        Vector3 pPos = this.transform.position;

        if(pPos.y >= -95.0f && pPos.y <= -91.0f) //1층 이동제한
            player.transform.position = new Vector3(Mathf.Clamp(pPos.x, -432.5f, 389.04f), pPos.y, pPos.z);

        if(pPos.y >= 146.0f && pPos.y <= 149.0f) //2층 이동제한
            player.transform.position = new Vector3(Mathf.Clamp(pPos.x, -352.1f, 259.2f), pPos.y, pPos.z);

        if(pPos.y >= -293.0f && pPos.y <= -290.0f) //B1층 이동제한
            player.transform.position = new Vector3(Mathf.Clamp(pPos.x, -321.0f, 379.2f), pPos.y, pPos.z);
    }
}
