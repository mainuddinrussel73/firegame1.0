using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    // Use this for initialization
    float bulletSpeed = 5f;
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0,bulletSpeed*Time.deltaTime,0);
        pos += velocity;
        transform.position = pos;
	}
}
