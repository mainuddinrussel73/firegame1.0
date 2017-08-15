using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEbullet : MonoBehaviour {


    float abulletSpeed = 3f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, abulletSpeed * Time.deltaTime, 0);
        pos -= velocity;
        transform.position = pos;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
          
            Destroy(gameObject);

        }
    }
}
