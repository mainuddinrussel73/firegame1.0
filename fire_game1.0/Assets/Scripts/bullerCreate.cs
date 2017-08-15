using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullerCreate : MonoBehaviour {


    float fireDelay = 1.05f;
    float coolDownTimer = 0f;
    public GameObject beams_48;
    // Use this for initialization
 
	
	// Update is called once per frame
	void Update () {
        coolDownTimer -= Time.deltaTime;
      
        Vector3 pos3 = transform.position;
        if (coolDownTimer<=0)
        {
            //Debug.Log("pew!!!");
            coolDownTimer = fireDelay;
          
            pos3.x = transform.position.x + 0.27f;
            pos3.y = transform.position.y + 1.43f;

         
            Instantiate(beams_48, pos3, transform.rotation);
        }
    }
}
