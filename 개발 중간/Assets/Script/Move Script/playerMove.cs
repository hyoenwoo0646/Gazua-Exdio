using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    float moveSpeed = 5.0f;
    GameObject player;
    public float Speed;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update () {
        Move();
	}

    void Move()
    {
        Vector3 moveV = Vector3.zero;
        this.player = GameObject.FindGameObjectWithTag("Player");
        Quaternion rota = this.transform.rotation; //플레이어 좌우 회전
        animator.SetBool("Working", false);


        if (Input.GetAxisRaw("Horizontal")<0)
        {
            moveV = Vector3.left;
            rota.eulerAngles = new Vector3(0, 180, 0);    //왼쪽 회전
            transform.rotation = Quaternion.Slerp(transform.rotation, rota, Time.deltaTime * 100.0f);  //회전 속도
            animator.SetBool("Working", true);
        }

        else if(Input.GetAxisRaw("Horizontal")>0)
        {
            moveV = Vector3.right;
            rota.eulerAngles = new Vector3(0, 0, 0);    //오른쪽 회전
            transform.rotation = Quaternion.Slerp(transform.rotation, rota, Time.deltaTime * 100.0f);    //회전 속도
            animator.SetBool("Working", true);
        }

        transform.position += moveSpeed * moveV * Time.deltaTime * Speed;

    }
}
