﻿using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Application.LoadLevel ("Level1");	
	}

	public void CarregaLevel(int Level){
		Application.LoadLevel (Level);
	}
}
