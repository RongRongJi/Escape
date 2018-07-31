using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject btnObj = GameObject.Find ("CardBag_button");
		Button btn = btnObj.GetComponent<Button> ();
		btn.onClick.AddListener (delegate () {
			this.GoCardBag ();
		});
		btnObj = GameObject.Find ("review_button");
		btn = btnObj.GetComponent<Button> ();
		btn.onClick.AddListener (delegate () {
			this.GoPlotReview ();
		});
		btnObj = GameObject.Find ("map_button");
		btn = btnObj.GetComponent<Button> ();
		btn.onClick.AddListener (delegate () {
			this.GoMap ();
		});

	}


	
	// Update is called once per frame
	void Update () {
		
	}

	public void GoCardBag(){
		SceneManager.LoadScene ("Scenes/CardBag");
	}
	public void GoPlotReview(){
		SceneManager.LoadScene ("Scenes/PlotReview");
	}
	public void GoMap(){
		SceneManager.LoadScene ("Scenes/Map");
	}
}
