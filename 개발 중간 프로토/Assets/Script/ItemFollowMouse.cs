using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFollowMouse : MonoBehaviour {      //선택된 아이템을 끌고 갈수 있도록 하는역할
	// Update is called once per frame
	void LateUpdate() {
        transform.position = Input.mousePosition;       //아이템을 끌었을때 마우스의 Position으로 계속 이동시킨다.
	}
}
