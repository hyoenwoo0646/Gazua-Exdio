using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting_exit : MonoBehaviour
{
    public GameObject go_1; // 인벤토리 활성화 비활성화.

    private bool activated_1; // 인벤토리 활성화시 true;
    private playerMove Move;
    private crafting_map map;

    // Use this for initialization
    void Start()
    { 
        Move = FindObjectOfType<playerMove>();
        map = FindObjectOfType<crafting_map>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnClickExit()
    {
        if (Input.GetMouseButtonUp(0)&&map.click ==true)
        {
            activated_1 = !activated_1;

            if (activated_1)
            {
                go_1.SetActive(false); //인벤토리 비활성화
                Move.Speed = 30;
            }
        }
    }
}
   