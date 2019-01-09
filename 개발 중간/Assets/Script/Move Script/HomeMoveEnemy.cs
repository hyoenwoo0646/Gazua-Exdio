using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeMoveEnemy : MonoBehaviour
{
    GameObject enemy_robot;
    
    
    void Update()
    {
        Wall();
    }
    void Wall()
    {
        this.enemy_robot = GameObject.FindGameObjectWithTag("Enemy");
        Vector3 pPos = this.transform.position;

        if(pPos.y >=-95.0f && pPos.y <= -91.0f)  //1층 이동제한
            enemy_robot.transform.position = new Vector3(Mathf.Clamp(pPos.x, -379.66f, 369.05f), pPos.y, pPos.z);
    }
}
