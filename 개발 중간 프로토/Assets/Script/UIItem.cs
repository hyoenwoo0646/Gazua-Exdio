using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //이미지 유형 사용하기위해, GetComponent <Image> ();함수 사용할려고 씀
using UnityEngine.EventSystems; //이벤트 시스템을 사용하여 캔버스와 같은 마우스 이벤트를 감지함


//아이템의 UI와 관련한 정보들을 넣는다.
public class UIItem : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler {       //마우스를 클릭할때, 마우스가 경계안에 들어갈때, 마우스를 땔때사용
    public Item item;           //아이템정보 가지고옴
    private Image spriteImage;  //스프라이트 이미지정보도 가지고옴
    private UIItem selectedItem;    //선택된 아이템에 대한 참조
    private Tooltip tooltip;
    void Awake()
    {
        selectedItem = GameObject.Find("SelectedItem").GetComponent<UIItem>();    //
        tooltip = GameObject.Find("Tooltip").GetComponent<Tooltip>();
        spriteImage = GetComponent<Image>();                    //슬롯내부의 항목정보들을 가지고온다.(아이템, 스프라이트)
        UpdateItem(null);       //테스트 목적 )슬롯내부에 적어도 하나의 빈슬롯을 갖고자할때 씀
    }

    public void UpdateItem(Item item)       //아이템을 표시하거나 숨길수있도록 함
    {
        this.item = item;
        if (this.item != null)      //업데이트해야할 아이템이 있을경우에
        {
            spriteImage.color = Color.white;    //색상이 불투명한 흰색이된다.
            spriteImage.sprite = item.icon;     //새항목의 아이콘을 덮어씌운다.
        }
        else
        {
            spriteImage.color = Color.clear;    //업데이트 해야할 아이템이 없을겨우스프라이트의 알파값을 0으로 만들어 투명상태로 하여 스프라이트를 보이게 한다.
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (this.item != null)      //클릭한 위치에 실제로 아이템이 있는지 확인
        {
            if (selectedItem.item != null)
            {
                Item clone = new Item(selectedItem.item);   //새로운 복제본을 복사한다.
                selectedItem.UpdateItem(this.item);     //클릭이 되었을때 UpdateItem을 통하여 클릭한 아이템은 화면에 없게 해두고 
                UpdateItem(clone);      //인벤토리안에 드래그한 항목을 저장한다.
            }
            else   //선택된 아이템이 없다면
            {
                selectedItem.UpdateItem(this.item); //해당 아이템을 집어들고
                UpdateItem(null); //해당 슬롯을 지운다
            }
        }
        else if (selectedItem.item != null)     //인벤토리에 항목이 없고 선택한 항목이 있는 경우
        {
            UpdateItem(selectedItem.item);  
            selectedItem.UpdateItem(null);  
        }
    }

    public void OnPointerEnter(PointerEventData eventData)  //마우스가 해당 아이템안에 들어갔을때 tooltip의 GenerateTootip을 호출하여 해당 tooltip정보를 보여줌
    {
       if (this.item != null)
       {
            tooltip.GenerateTooltip(this.item);
       }
    }

    public void OnPointerExit(PointerEventData eventData)   //마우스가 해당 아이템에 없을경우 해당 tootip을 끈다.
    {
        tooltip.gameObject.SetActive(false);
    }
}
