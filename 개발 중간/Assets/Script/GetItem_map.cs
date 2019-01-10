using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem_map : MonoBehaviour
{
    public bool click;
    GameObject getpoint;
    // Start is called before the first frame update
    void Start()
    {
        getpoint = GameObject.Find("getpoint");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        click = false;
        if (other.gameObject.tag == "Player")
        {
            click = true;
            getpoint.GetComponent<Renderer>().enabled = true;

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            click = false;
            getpoint.GetComponent<Renderer>().enabled = false;
        }
    }
}

