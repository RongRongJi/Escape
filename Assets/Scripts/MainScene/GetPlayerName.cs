using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mono.Data.Sqlite;
using System.IO;
using UnityEngine.UI;

public class GetPlayerName  :MonoBehaviour
{
	public Text objText;

	private string player_name;

	void Start()
	{



		//如果运行在编辑器中
		#if UNITY_EDITOR
		//通过路径找到第三方数据库
		string appDBPath = Application.dataPath + "/Plugins/Android/assets/" + "escape.db";
		DbAccess db = new DbAccess("URI=file:" + appDBPath);

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
		DbAccess db = new DbAccess("URI=file:" + appDBPath);
		#endif


		using (SqliteDataReader sqReader = db.SelectWhere("Player", new string[]{"player_name"}, new string[]{"id"}, new string[] {"="}, new string[] {"1"}))
		{
			Debug.Log("Begining Select !!!"); 
			while (sqReader.Read())
			{
				player_name = sqReader.GetString(sqReader.GetOrdinal("player_name"));
				objText.text = player_name;
			}

			sqReader.Close();

			db.CloseSqlConnection();
		}

	}
		

}