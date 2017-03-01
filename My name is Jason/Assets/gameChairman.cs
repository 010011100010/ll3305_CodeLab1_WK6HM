using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class gameChairman : MonoBehaviour {

	// Use this for initialization
	void Start () {
		JSONClass json = new JSONClass ();
		json ["x"].AsFloat = 7;
		json ["y"].AsFloat = 0;
		json ["z"].AsFloat = 2;
		Debug.Log (json);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
