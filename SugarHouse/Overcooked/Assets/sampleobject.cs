﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleobject : MonoBehaviour {

    public GameObject enemy;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemy);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
