﻿using UnityEngine;
using System.Collections;

public class SelfDestroyer : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		Destroy(this.gameObject, 3);
	}
}