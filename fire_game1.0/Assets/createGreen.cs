using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createGreen : MonoBehaviour {

    // Use this for initialization\
    public GameObject ELxFZ;
    Vector3 whereToSpawn;
    void Start () {
        whereToSpawn = new Vector2(-3.37f, 7.04f);
        Instantiate(ELxFZ, whereToSpawn, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {

		
	}
}
