using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buller1 : MonoBehaviour {
    float fireDelay = 1.05f;
    float coolDownTimer = 0f;
    public GameObject beams_48_1;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        coolDownTimer -= Time.deltaTime;

        Vector3 pos3 = transform.position;
        if (coolDownTimer<=0)
        {

            coolDownTimer = fireDelay;

            pos3.x = transform.position.x - 0.4200326f;
            pos3.y = transform.position.y + 1.482468f;


            Instantiate(beams_48_1, pos3, transform.rotation);
        }
    }
}
