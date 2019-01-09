using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//마우스를 드래그했을때 해당 정보를 나오게함 
public class Tooltip : MonoBehaviour {
    private Text tooltipText;         //툴팁을 작성할때 쓸 Text정보

	void Start () {     //게임이 시작될때 툴팁이 보이지 않게 하기위해서
        tooltipText = GetComponentInChildren<Text>();
        gameObject.SetActive(false);
	}

    public void GenerateTooltip(Item item)      //아이템 내부에 읽을 통계가 있는지 확인한다
    {
        string statText = "";       //모든항목의 통계와 값을 statText에 저장
        if (item.stats.Count > 0)
        {
            foreach(var stat in item.stats)
            {
                statText += stat.Key.ToString() + ": " + stat.Value + "\n"; //모든항목의 통계와 값을 statText에 저장
            }
        }

        string tooltip = string.Format("<b>{0}</b>\n\n{1}\n\n\n\n\n<b>{2}</b>", item.title, item.description, statText);    //툴팁 작성및 여러줄을 반복하여 강조함
        tooltipText.text = tooltip;
        gameObject.SetActive(true);
    }
}
