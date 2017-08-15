using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidCreate : MonoBehaviour {

    // Use this for initialization
    float astroSpeed = 3f;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, astroSpeed * Time.deltaTime, 0);
        pos -= velocity;
        transform.position = pos;
    }
}
