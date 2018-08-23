using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardShow{

	public void Start (int num) {
        GameObject cardName = GameObject.Find("Canvas/背景图片/技能信息/卡片情报/CardName");
        Text txtCardName = cardName.GetComponent<Text>();
        txtCardName.text = GetSkill.cardName[num];

        GameObject cardProperty = GameObject.Find("Canvas/背景图片/技能信息/卡片情报/CardProperty");
        Text txtProperty = cardProperty.GetComponent<Text>();
        txtProperty.text = GetSkill.cardProperty[num];


        //Image imgProperty = cardProperty.GetComponent<Image>();
        //imgProperty = Resources.Load("1", typeof(Image)) as Image;

        GameObject cardRare = GameObject.Find("Canvas/背景图片/技能信息/卡片情报/CardRare");
        Image imgCardRare = cardRare.GetComponent<Image>();
        imgCardRare.sprite = Resources.Load("卡片背包/卡片边框（"+GetSkill.cardRare[num]+"）", typeof(Sprite)) as Sprite;

        //txtCardName.text = GetSkill.cardName[num];

        GameObject cardInfo = GameObject.Find("Canvas/背景图片/技能信息/卡片情报/CardInfo");
        Text txtCardInfo = cardInfo.GetComponent<Text>();
        txtCardInfo.text = GetSkill.infomation[num];

        GameObject extraInfo1 = GameObject.Find("Canvas/背景图片/技能信息/卡片情报/ExtraInfo1");
        Text txtExtraInfo1 = extraInfo1.GetComponent<Text>();
        txtExtraInfo1.text = GetSkill.extraInfo1[num];

        GameObject extraInfo2 = GameObject.Find("Canvas/背景图片/技能信息/卡片情报/ExtraInfo2");
        Text txtExtraInfo2 = extraInfo2.GetComponent<Text>();
        txtExtraInfo2.text = GetSkill.extraInfo2[num];

        GameObject cardDrawImg = GameObject.Find("Canvas/背景图片/技能信息/卡片情报/CardDrawImg");
        Image imgDrawImg = cardDrawImg.GetComponent<Image>();
        txtCardName.text = GetSkill.cardName[num];
    }
	
	void Update () {
		
	}
}
