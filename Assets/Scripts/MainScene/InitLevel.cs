using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitLevel : MonoBehaviour {

	//等级
	int level;
	public Image levelPrefab;
	Image[] levelNum;
	int levelpercent;
	//头像
	public Image headImage;
	//玩家昵称
	Text text;


	//float scale = 0.25f;


	// Use this for initialization
	void Start () {
		float scale = transform.lossyScale.x;
		float x = Screen.width * 0.17f;
		float y = Screen.height * 0.85f;
		gameObject.transform.position = new Vector3 (x, y);

		//加载等级数字
		levelNum = new Image[3];
		if (null != levelNum) {
			//设置等级位置
			float width = gameObject.GetComponent<RectTransform> ().rect.width * scale;
			float height = gameObject.GetComponent<RectTransform> ().rect.height * scale;
			x = gameObject.transform.position.x;
			y = gameObject.transform.position.y;
			for (int i = 0; i < 3; i++) {
				levelNum [i] = Instantiate (levelPrefab) as Image;
				levelNum [i].transform.parent = GameObject.Find ("Canvas").gameObject.transform;
				levelNum [i].transform.localScale = new Vector3 (2f, 0.75f, 1f);
			}
			levelNum [0].rectTransform.position = new Vector3 (x-width/18,y+height/12);
			levelNum [1].rectTransform.position = new Vector3 (x, y + height / 12);
			levelNum [2].rectTransform.position = new Vector3 (x + width / 18, y + height / 12);
		}
		if (null != headImage) {
			//设置头像位置
		}
	}
	
	// Update is called once per frame
	void Update () {
		//等级数字改变
		bool head = true;//首位
		if (null != levelNum) {
			int[] levels = ChangeLevel ();
			for (int i = 0,j = 2; i < 3; ) {
				if (j<0){
					levelNum [i].gameObject.SetActive (false);
					i++;
					j--;
				} else if(levels [j] == 0 && head) {
					j--;
				} else {
					head = false;
					levelNum [i].gameObject.SetActive (true);	
					levelNum [i].sprite = Resources.Load ("MainScene/" + levels [j], typeof(Sprite)) as Sprite;
					j--;
					i++;
				}
			}
		}
	}

	//通过数据库获取当前等级
	int GetLevel(){
		return 2;
	}

	//处理当前等级
	int[] ChangeLevel(){
		int[] levels = new int[3];
		int tmp = GetLevel ();
		int hand = 0;
		while (tmp > 0) {
			levels [hand] = tmp % 10;
			tmp /= 10;
			hand++;
		}
		return levels;
	}
}
