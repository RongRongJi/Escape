using UnityEngine;
using System.Collections;
using System.IO;

public class CreateDB : MonoBehaviour {

	//  public GameObject objDB;
	private string appDBPath;
	private DbAccess db;

	// Use this for initialization
	void Start () {


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


		db.CreateTable("Player", new string[] { "id", "player_name" }, new string[] { "text", "text"});
		db.InsertInto("Player", new string[] { "'1'", "'内测玩家'" });

		//   objDB.SetActive(false);

		db.CloseSqlConnection();
	}

	// Update is called once per frame
	void Update () {

	}

}
