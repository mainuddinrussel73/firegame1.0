using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {
    float speed = 3f;
    public Vector2 target;
   
    // Use this for initialization
    void Start () {

        float s = Random.Range(-12f, 15f);
        float s1 = Random.Range(15f, 18f);
        target.x = transform.position.x +s;
        target.y = transform.position.y -18f- s1;
    }

    // Update is called once per frame
    void Update()
    {
        

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }
}
