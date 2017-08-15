using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misslelaunch : MonoBehaviour {

    // Use this for initialization
    float fireDelay = 3.05f;
    float coolDownTimer = 0f;
    public GameObject missile;

    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        coolDownTimer -= Time.deltaTime;

        Vector3 pos3 = transform.position;
        if (coolDownTimer <= 0)
        {

            coolDownTimer = fireDelay;

            pos3.x = transform.position.x ;
            pos3.y = transform.position.y + 1.482468f;



            Instantiate(missile, pos3, transform.rotation);
        }
    }
}
