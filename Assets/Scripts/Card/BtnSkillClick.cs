using Mono.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class BtnSkillClick{
    private int num;

	public void Start () {

        //num = GetSkill.cardName.Length;
        //int i = 0;
        /* while (i < num)
         {
             Button btn;
             if (i == num - 1)
             {
                 btn = LoadLastSkill(i);
             }
             else
             {
                 btn = LoadSkill(i);
             }
             ClickEvent(btn,i);
             i++;
         }*/

        Start1();
    }

    Button LoadSkill(int num)
    {
        GameObject btnObj = GameObject.Find("Canvas/背景图片/ScrollRect/Grid/技能显示框架" + num + "/btnSkill");
        GameObject imgSkill = GameObject.Find("Canvas/背景图片/ScrollRect/Grid/技能显示框架" + num + "/btnSkill/imgSkill");

        Button btn = btnObj.GetComponent<Button>();
        Image imgFrame = btnObj.GetComponent<Image>();
        Image img = imgSkill.GetComponent<Image>();
        imgFrame.sprite = Resources.Load("卡片背包/滑动条预览（" + GetSkill.cardRare[num] + "）", typeof(Sprite)) as Sprite;
        img.sprite = Resources.Load("卡片背包/卡片属性（" + GetSkill.cardProperty[num] + "）", typeof(Sprite)) as Sprite;

        return btn;
    }

    Button LoadLastSkill(int num)
    {
        GameObject frame = GameObject.Find("Canvas/背景图片/ScrollRect/Grid/技能显示框架" + num);
        GameObject btnObj = GameObject.Find("Canvas/背景图片/ScrollRect/Grid/技能显示框架" + num + "/btnSkill");
        GameObject imgSkill = GameObject.Find("Canvas/背景图片/ScrollRect/Grid/技能显示框架" + num + "/btnSkill/imgSkill");

        Button btn = btnObj.GetComponent<Button>();
        Image imgFrame = frame.GetComponent<Image>();
        Image imgSkillFrame = btnObj.GetComponent<Image>();
        Image img = imgSkill.GetComponent<Image>();
        imgFrame.sprite = Resources.Load("卡片背包/滑动条-后续（未停留）（改）",typeof(Sprite)) as Sprite;
        imgSkillFrame.sprite = Resources.Load("卡片背包/滑动条预览（" + GetSkill.cardRare[num] + "）", typeof(Sprite)) as Sprite;
        img.sprite = Resources.Load("卡片背包/卡片属性（" + GetSkill.cardProperty[num] + "）", typeof(Sprite)) as Sprite;

        return btn;
    }

    void ClickEvent(Button btn,int num)
    {
        btn.onClick.AddListener(delegate ()
        {
            CardShow cardShow = new CardShow();
            cardShow.Start(num);
        });
    }
	



    public void Start1()
    {
        int i = 0;
        GameObject Grid = GameObject.Find("Canvas/背景图片/ScrollRect/Grid");
        foreach (Transform game in Grid.transform)
        {
            
            foreach (Transform game1 in game.transform)
            {
                foreach(Transform game2 in game1.transform)
                {
                    GameObject frame = game.gameObject;
                    GameObject btnObj = game1.gameObject;
                    GameObject imgSkill = game2.gameObject;

                    Button btn = btnObj.GetComponent<Button>();
                    Image imgFrame = frame.GetComponent<Image>();
                    Image imgSkillFrame = btnObj.GetComponent<Image>();
                    Image img = imgSkill.GetComponent<Image>();
                    if (game == Grid.transform.GetChild(Grid.transform.childCount - 1))
                        imgFrame.sprite = Resources.Load("卡片背包/滑动条-后续（未停留）", typeof(Sprite)) as Sprite;
                    else
                        imgFrame.sprite = Resources.Load("卡片背包/滑动条-后续（未停留）（改）", typeof(Sprite)) as Sprite;
                    imgSkillFrame.sprite = Resources.Load("卡片背包/滑动条预览（" + GetSkill.cardRare[i] + "）", typeof(Sprite)) as Sprite;
                    img.sprite = Resources.Load("卡片背包/卡片属性（" + GetSkill.cardProperty[i] + "）", typeof(Sprite)) as Sprite;

                    ClickEvent(btn, i);
                }
            }
            i++;
        }
    }
}
