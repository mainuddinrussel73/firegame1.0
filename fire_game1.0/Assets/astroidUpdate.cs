using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidUpdate : MonoBehaviour {

    // Use this for initialization
    public float atimer = 10f;
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
