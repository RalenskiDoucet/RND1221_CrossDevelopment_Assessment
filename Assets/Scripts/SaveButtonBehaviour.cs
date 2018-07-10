using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Serialization;
[Serializable]
public class SaveButtonBehaviour : MonoBehaviour
{
    public int level;
    public float timeElasped;
    public string playerName;

    private SaveButtonBehaviour myData = new SaveButtonBehaviour();

    public GameObject Obj1Data=GameObject.FindGameObjectWithTag("HUD");
    void OnClick()
    {
        File.OpenWrite("Obj1Data");
    }
	// Use this for initialization
	void Start () {
		OnClick();
	 
	}
	
	// Update is called once per frame
	void Update () {
		OnClick();
	    myData.level = 1;
	    myData.timeElasped = 10.00f;
	    myData.playerName = "Ralenski";
	    string json = JsonUtility.ToJson("myData");
    }
}
