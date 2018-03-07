using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startBtn : MonoBehaviour {

    public Text InputEmailText;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startGame()
    {
        string ID = InputEmailText.text;
        Debug.Log("ID = " + ID);
    }
}
