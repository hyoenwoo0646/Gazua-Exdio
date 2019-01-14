using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreatureMovement : MonoBehaviour
{
    public float movePower = 1f;        //이동속도

    Vector3 movement;
    int movementFlag = 0;
    bool isTracing;
    bool isMoving;
    GameObject traceTaget;
    GameObject Player;
    GameObject Enemy;
    GameObject danger;
    GameObject Fight;
    GameObject Defense;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangeMovement");
        Player = GameObject.Find("Player");
        Enemy = GameObject.Find("enemy_robot");
        danger = GameObject.Find("danger");
        Fight = GameObject.Find("Fight_UI");
        Defense = GameObject.Find("Defense_UI");

        Fight.active = false;
        Defense.active = false;
    }

    IEnumerator ChangeMovement()
    {
        movementFlag = Random.Range(1, 3);

        yield return new WaitForSeconds(3);

        StartCoroutine("ChangeMovement");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            traceTaget = other.gameObject;


            StopCoroutine("ChangeMovemnet");

            danger.GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            isTracing = true;
            movePower += 1;
            isMoving = true;
            if(movePower >= 100)
            {
                movePower = 100;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTracing = false;
            isMoving = false;
            StartCoroutine("ChangeMovement");
            movePower = 50;

            danger.GetComponent<Renderer>().enabled = false;
            Fight.active = false;
            Defense.active = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;
        Vector3 Player_Move = Player.transform.position;
        Vector3 Enemy_Move = Enemy.transform.position;

        if (isTracing)
        {
            Vector3 playerPos = traceTaget.transform.position;

            if (playerPos.x < transform.position.x)
                movementFlag = 1;
            else if (playerPos.x > transform.position.x)
                movementFlag = 2;
        }
        else
        {
            if (movementFlag == 1)
                movementFlag = 1;
            else if (movementFlag == 2)
                movementFlag = 2;
        }

        if (movementFlag == 1)
        {
            moveVelocity = Vector3.left;
            transform.localScale = new Vector3(20, 20, 1);
        }

        else if(movementFlag == 2)
        {
            moveVelocity = Vector3.right;
            transform.localScale = new Vector3(-20, 20, 1);
        }

        //플레이어와 일정거리에서 마주칠 시 , movePower을 0 으로 설정

        float distance = Vector3.Distance(Player.transform.position, Enemy.transform.position);

        if(distance < 50 && isMoving == true)
        {
            movePower = 0;
            Fight.active = true;
            Defense.active = true;
        }
        else if(distance > 51 && isMoving == false)
        {
            movePower = 50;
        }


        transform.position += moveVelocity * movePower * Time.deltaTime;
    }
}
