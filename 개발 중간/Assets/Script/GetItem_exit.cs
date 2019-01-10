using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem_exit : MonoBehaviour
{
    private GetItem_map getmap;
    private playerMove Move;

    private bool activated_1;
    public GameObject go_1;
    public GameObject go_2;
    // Start is called before the first frame update
    void Start()
    {
        getmap = FindObjectOfType<GetItem_map>();
        Move = FindObjectOfType<playerMove>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
        if (getmap.click == true && Input.GetMouseButtonUp(0))
        {
            activated_1 = !activated_1;

            if (activated_1)
            {
                go_1.SetActive(false); //파밍창 활성화
                go_2.SetActive(false); //인벤창 활성화
                Move.Speed = 30;
            }
        }

    }
}

