using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Crafting_Box : MonoBehaviour {
    public GameObject go_1; // 인벤토리 활성화 비활성화.

    private bool activated_1; // 인벤토리 활성화시 true;
    private playerMove Move;
    private crafting_map map;

    // Use this for initialization
    void Start ()
    {
        Move = FindObjectOfType<playerMove>();
        map = FindObjectOfType<crafting_map>();
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void OnMouseOver()
    {
        if (map.click == true &&Input.GetMouseButtonUp(0))
        {
            activated_1 = !activated_1;

            if (activated_1)
            {
                go_1.SetActive(true); //조합창 활성화
                Move.Speed = 0;
            }
        }
    }
}
