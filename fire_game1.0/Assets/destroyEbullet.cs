using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEbullet : MonoBehaviour {

    public float atimer = 5f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        atimer -= Time.deltaTime;
        if (atimer <= 0)
        {
            Destroy(gameObject);

        }

    }
}
