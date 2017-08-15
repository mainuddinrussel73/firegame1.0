using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createRotateBullet : MonoBehaviour {


    public float qfireDelay = 1.5f;
    float qcoolDownTimer = 0.4f;
    public GameObject beams_0, beams_1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        qcoolDownTimer -= Time.deltaTime;

        Vector3 pos3 = transform.position;
        Vector3 pos4 = transform.position;
        if (qcoolDownTimer <= 0)
        {
            Debug.Log("dew!!!");
            qcoolDownTimer = qfireDelay;

            pos3.x = transform.position.x - 1.12f;
            pos3.y = transform.position.y - 1.94f;

            pos4.x = transform.position.x + 1.3f;
            pos4.y = transform.position.y - 1.9f;

           

            Instantiate(beams_0, pos3, transform.rotation);
            Instantiate(beams_1, pos4, transform.rotation);
         
        }

    }
}
