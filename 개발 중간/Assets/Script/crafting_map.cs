using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crafting_map : MonoBehaviour
{
    public bool click;
    // Start is called before the first frame update
    void Start()
    {
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
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            click = false;
        }
    }
}
