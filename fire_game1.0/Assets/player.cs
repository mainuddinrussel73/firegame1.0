using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player : MonoBehaviour {

    float directionX;
    Rigidbody2D rd;

    // Use this for initialization
    void Start () {
        rd = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        directionX = CrossPlatformInputManager.GetAxis("Horizontal");
        rd.velocity = new Vector2(directionX * 100, 0);
        Debug.Log(directionX);
        Debug.Log("yap clicked");
    }
}
