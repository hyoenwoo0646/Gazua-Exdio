using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour {
    public List<Item> items = new List<Item>(); //아이템의 기본적인 데이터베이스 값 받기

    void Awake()
    {
        BuildDatabase();        //시작할때 BuildDatabase 함수를 호출
    }

    public Item GetItem(int id)
    {
        return items.Find(item=> item.id == id);        //반복을 통하여서 아이템 리스트에서 특정 아이템 ID를 찾아낸다.
    }

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);      //제목을 사용하여서 아이템 인벤토리화면에 액세스 하는역할
    }

    void BuildDatabase()
    {
        items = new List<Item>() {                  //아이템 값을 넣어준다. *이곳이 아이템 데이터베이스의 기본이 되는곳
            new Item(0, "나무", "단단한 나무.",   
            new Dictionary<string, int> {
                { "Power", 15 },
                { "Defence", 10 }
            }),
            new Item(1, "유리", "잘 깨지는 유리",
            new Dictionary<string, int> {
                { "Value", 300 }
            }),
            new Item(2, "철", "단단한 철",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(3, "고무", "질긴 고무",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(4, "아싸히", "마시면 어떻게될까?",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            })
        };
    }
}
