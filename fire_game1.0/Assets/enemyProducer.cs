using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyProducer : MonoBehaviour {

    public GameObject enemy;
    public GameObject enemy1;
    //public GameObject enemy2;
    float rendx;
    Vector2 whereToSpawn;
    float timer = 2f;
    public float spwanRate = 10f;
    public float spwanRate1= 5f;
    float nextSpwan = 0.0f;
    float secoundSwan = 0.10f;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        if (Time.time > nextSpwan)
        {
            nextSpwan = Time.time + spwanRate;
            rendx = Random.Range(-6.63f, 6.63f);
            whereToSpawn = new Vector2(rendx, transform.position.y);
            //Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
        if (Time.time > secoundSwan)
        {
            secoundSwan = Time.time + spwanRate1;
            rendx = Random.Range(-6.64f, 6.64f);
            whereToSpawn = new Vector2(rendx, transform.position.y);
            Instantiate(enemy1, whereToSpawn, Quaternion.identity);

        }
        
       
        
	}
}
