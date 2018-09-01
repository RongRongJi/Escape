using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back_Menu : MonoBehaviour {

    public Button Back_Button;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //返回主界面
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainScene");
    }
}
