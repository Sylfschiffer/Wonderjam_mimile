﻿using UnityEngine;
using System.Collections;

public class weaponChoice : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void afficher_Cacher(bool IsVisible )
	{
		if (IsVisible == true) {
			GetComponent<CanvasGroup>().alpha = 1;
		} 
		
		else {
			
			GetComponent<CanvasGroup>().alpha = 0;
		}
	}



}
