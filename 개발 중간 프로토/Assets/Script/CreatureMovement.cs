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
    GameObject traceTaget;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangeMovement");
    }

    IEnumerator ChangeMovement()
    {
        movementFlag = Random.Range(0, 3);

        yield return new WaitForSeconds(3);

        StartCoroutine("ChangeMovement");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            traceTaget = other.gameObject;

            StopCoroutine("ChangeMovemnet");
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            isTracing = true;
            movePower += 1;

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

            StartCoroutine("ChangeMovement");
            movePower = 50;
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

        transform.position += moveVelocity * movePower * Time.deltaTime;
    }
}
