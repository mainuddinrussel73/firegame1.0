using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private float timer = 3f;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);

        }
    }
}
