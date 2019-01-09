using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public List<Item> characterItems = new List<Item>();        //캐릭터의 아이템 리스트 작성
    public ItemDatabase itemDatabase;       //데이터베이스에서 정보를 꺼내온다.
    public UIInventory inventoryUI;     //인벤토리의 UI 부분의 정보를 가지고온다.

    void Start()    //아이템을 주면서 시작한다.
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))        //"I" 키를 누르면 인벤토리 껐다 , 켰다 가능
        {
            inventoryUI.gameObject.SetActive(!inventoryUI.gameObject.activeSelf);
        }
    }

    public void GiveItem(int id)    //아이템의 ID 정보값를 characterItems에 준다. //강제로 아이템을 인벤토리에 옮기는역할 위에 Start에 GiveItem()을 통하여
    {
        Item itemToAdd = itemDatabase.GetItem(id);  //아이템의 데이터베이스를 얻는다.
        characterItems.Add(itemToAdd);              //characterItem에 해당 아이템을 집어넣는다.
        inventoryUI.AddNewItem(itemToAdd);      //UIinventory기능으로 아이템을 넣는다.
        Debug.Log("Added item: " + itemToAdd.title);    //로그에 띄워줌
    }

    public Item CheckForItem(int id)        //이 아이템이 여기에 있는게 맞는지 확인한다. ~드래그 시 확인용
    {
        return characterItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)      //마찬가지로 아이템 제거시
    {
        Item itemToRemove = CheckForItem(id);
        if (itemToRemove != null)
        {
            characterItems.Remove(itemToRemove);
            inventoryUI.RemoveItem(itemToRemove);
            Debug.Log("Removed item: " + itemToRemove.title);
        }
    }
}
