using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButtonPosition : MonoBehaviour {

	public Button CardBag_button;
	public Button review_button;
	public Button map_button;
	//float scale = 0.25f;
	float scale;

	// Use this for initialization
	void Start () {
		scale = transform.lossyScale.x;
		float cardWidth = CardBag_button.GetComponent<RectTransform> ().rect.width * transform.lossyScale.x;
		float cardHeight = CardBag_button.GetComponent<RectTransform> ().rect.height * transform.lossyScale.y;
		float reviewWidth = review_button.GetComponent<RectTransform> ().rect.width * transform.lossyScale.x;
		float reviewHeight = review_button.GetComponent<RectTransform> ().rect.height * transform.lossyScale.y;
		float mapWidth = map_button.GetComponent<RectTransform> ().rect.width * transform.lossyScale.x;
		float mapHeight = map_button.GetComponent<RectTransform> ().rect.height * transform.lossyScale.y;
		//设置卡片背包的位置
		float x = Screen.width * 0.9f;
		float y = Screen.height * 0.2f;
		CardBag_button.transform.position = new Vector3 (x, y);
		//设置副本的位置
		x = CardBag_button.transform.position.x + mapWidth / 2;
		y = CardBag_button.transform.position.y + cardHeight / 2 ;
		map_button.transform.position = new Vector3 (x, y);
		//设置剧本回顾的位置
		x = CardBag_button.transform.position.x - cardWidth / 2 ;
		y = CardBag_button.transform.position.y - reviewHeight / 2;
		review_button.transform.position = new Vector3 (x, y);

	}
	

}
