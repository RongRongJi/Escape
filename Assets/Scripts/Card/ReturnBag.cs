using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnBag : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject btnObj = GameObject.Find("return_Bag_Button");
        Button btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate () {
            this.BackCardBag();
        });
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void BackCardBag()
    {
        SceneManager.LoadScene("Scenes/MainScene");
    }
}
