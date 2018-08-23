using Mono.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GetSkill : MonoBehaviour {
    //  public GameObject objDB;
    private string appDBPath;
    private DbAccess db;
    private SqliteDataReader sqReader;

    private int size;
    public static string []cardName;
    public static string[] cardRare;
    public static string[]cardProperty;
    public static string[]cardIcon;
    public static string[]cardDrawImg;
    public static string[]infomation;
    public static string[]extraInfo1;
    public static string[]extraInfo2;

    void Start()
    {
      
        getConn();
        initArray();
        doConn();
        showCard();
        initSkill();
        addClickEvent();
        closeConn();
    }

    void getConn()
    {
        //如果运行在编辑器中
#if UNITY_EDITOR
        //通过路径找到第三方数据库
        string appDBPath = Application.dataPath + "/Plugins/Android/assets/" + "escape.db";
        db = new DbAccess("URI=file:" + appDBPath);

        //如果运行在Android设备中
#elif UNITY_ANDROID
		//将第三方数据库拷贝至Android可找到的地方
		string appDBPath = Application.persistentDataPath + "/" + "escape.db";
		//如果已知路径没有地方放数据库，那么我们从Unity中拷贝
		if(!File.Exists(appDBPath))
		{
		//用www先从Unity中下载到数据库
		WWW loadDB = new WWW("jar:file://" + Application.dataPath + "!/assets/" + "escape.db"); 


		while(!loadDB.isDone){}
		//拷贝至规定的地方
		File.WriteAllBytes(appDBPath, loadDB.bytes);
		}

		//在这里重新得到db对象。
		db = new DbAccess("URI=file:" + appDBPath);
#endif
    }

    void initArray()
    {
        sqReader = db.ExecuteQuery("select count(*) from Card");
        while (sqReader.Read())
        {
            size = Convert.ToInt32(sqReader[0].ToString());
            cardName = new string[size];
            cardRare = new string[size];
            cardProperty = new string[size];
            cardIcon = new string[size];
            cardDrawImg = new string[size];
            infomation = new string[size];
            extraInfo1 = new string[size];
            extraInfo2 = new string[size];

        }
        sqReader.Close();
    }

    void initSkill()
    {
        GameObject Grid = GameObject.Find("Canvas/背景图片/ScrollRect/Grid");
        Debug.Log(cardName.Length);
        Debug.Log(Grid.transform.childCount);
        int addNewTransform = cardName.Length - Grid.transform.childCount;
        for (int i = 0;i< addNewTransform;i++)
        {
            GameObject frame = Instantiate(Resources.Load("卡片背包/技能显示框架", typeof(GameObject))) as GameObject;
            transform.localScale = new Vector3(1, 1, 1);
            frame.transform.SetParent(Grid.transform);
        }
    }

    void doConn()
    {
        sqReader = db.ReadFullTable("Card");
        int i = 0;
        while (sqReader.Read())
        {
            cardName[i] = sqReader.GetString(sqReader.GetOrdinal("CardName"));
            cardRare[i] = sqReader.GetString(sqReader.GetOrdinal("CardRare"));
            cardProperty[i] = sqReader.GetString(sqReader.GetOrdinal("CardProperty"));
            cardIcon[i] = sqReader.GetString(sqReader.GetOrdinal("CardIcon"));
            cardDrawImg[i] = sqReader.GetString(sqReader.GetOrdinal("CardDrawImg"));
            infomation[i] = sqReader.GetString(sqReader.GetOrdinal("Infomation"));
            extraInfo1[i] = sqReader.GetString(sqReader.GetOrdinal("ExtraInfo1"));
            extraInfo2[i] = sqReader.GetString(sqReader.GetOrdinal("ExtraInfo2"));
            i++;
        }
        sqReader.Close();
    }

    void closeConn() { db.CloseSqlConnection(); }

    void showCard()
    {
        CardShow cardShow = new CardShow();
        cardShow.Start(0);
    }

    void addClickEvent()
    {

        BtnSkillClick btnSkillClick = new BtnSkillClick();
        btnSkillClick.Start();
    }

}
