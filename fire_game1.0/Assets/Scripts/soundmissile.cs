using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmissile : MonoBehaviour {
    public AudioSource someting;
    float fireDelay = 1.05f;
    float coolDownTimer = 0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        coolDownTimer -= Time.deltaTime;

        if (coolDownTimer <= 0)
        {
            coolDownTimer = fireDelay;
            someting.Play();
        }
	}
}
