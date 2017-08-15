using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEbullet : MonoBehaviour {


    public float qfireDelay = 1.5f;
    float qcoolDownTimer = 0.4f;
    public GameObject beams_16;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        qcoolDownTimer -= Time.deltaTime;

        Vector3 pos3 = transform.position;
        if (qcoolDownTimer <= 0)
        {
            //Debug.Log("dew!!!");
            qcoolDownTimer = qfireDelay;

            pos3.x = transform.position.x;
            pos3.y = transform.position.y - 3f;


            Instantiate(beams_16, pos3, transform.rotation); 
        }

    }
}
