using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chapter_Unlock : MonoBehaviour {

    private bool isSelect = false;
    private bool isSelected = false;
    public GameObject Image_Chapter;
    public GameObject Button_Chapter_Unpassed;
    public GameObject Button_Chapter_Unlock;
    public GameObject Button_Chapter;
    public GameObject Point;
    public GameObject Point_Unlock;

    // Use this for initialization
    void Start() {

        if (transform.parent.GetChild(0).name == gameObject.name)
        {
            isSelect = true;
        }

        if (isSelect)
        {
            Button_Chapter.SetActive(false);
            Button_Chapter_Unpassed.SetActive(true);
            Image_Chapter.SetActive(true);
            Point.SetActive(false);
            Point_Unlock.SetActive(true);
        }

        if (isSelected)
        {
            Button_Chapter_Unpassed.SetActive(false);
            Button_Chapter_Unlock.SetActive(true);
        }
    }


	
	// Update is called once per frame
	void Update () {
		
	}

}
