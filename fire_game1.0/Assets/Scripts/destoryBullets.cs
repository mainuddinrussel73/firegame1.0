﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryBullets : MonoBehaviour {
    public float timer = 3f;
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer<=0)
        {
            Destroy(gameObject);

        }
	}
}
