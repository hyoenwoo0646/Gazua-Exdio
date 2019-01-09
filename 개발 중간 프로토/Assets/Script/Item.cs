using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();   //Dictionary -> 아이템의 공격력이나 값등을 설정하기 위해 설정

    public Item(int id, string title, string description, Dictionary<string, int> stats)    //아이템값을 이 Item이라는 클래스의 시작과 동시에 반복함
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + title);       //Resources -> Sprites -> Items 폴더 순으로 아이템이 저장되어있어야한다. 필수!
        this.stats = stats;
    }

    public Item(Item item)          //나중에 하나의 Item을 복사하고 다른 Item을 생성하기 위해 사용한 생성자 (정확한 의미 알기 힘듬)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + item.title);
        this.stats = item.stats;
    }
}
