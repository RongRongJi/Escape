using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Chapter_Select : MonoBehaviour {

    public Button Chapter0;
    public Button Chapter1;
    public Button Chapter2;
    public Button Chapter3;
    public Button Chapter4;
    public Button Chapter5;
    public Button Chapter6;
    public Button Chapter7;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EnterLevel0()
    {
        SceneManager.LoadScene("CardBag");
    }

    public void EnterLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void EnterLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void EnterLevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void EnterLevel4()
    {
        SceneManager.LoadScene(4);
    }

    public void EnterLevel5()
    {
        SceneManager.LoadScene(5);
    }

    public void EnterLevel6()
    {
        SceneManager.LoadScene(6);
    }

    public void EnterLevel7()
    {
        SceneManager.LoadScene(7);
    }
}
