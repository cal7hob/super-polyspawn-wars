﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnerExplosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 2f);	
	}	
}