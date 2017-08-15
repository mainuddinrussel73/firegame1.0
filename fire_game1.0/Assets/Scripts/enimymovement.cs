using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimymovement : MonoBehaviour {


    float maxSpeedX = 20f;
    //public float timer = 5f;
    Vector3 pos1;
    bool flag = false;
    public bool isDestroyed = false;
    // Use this for initialization
    public GameObject ExplosionGO;
    public AudioSource someting;

    // Update is called once per frame
    private float timer = 33f;

    void Start()
    {
        pos1 = transform.position;
        pos1.x = Random.Range(-6.63f, 6.63f);
        pos1.y = Random.Range(6.63f, 6.63f);
    }
    void Update() {
        timer -= Time.deltaTime;



        if (timer > 0f && timer <= 6f)
        {
            
            pos1.y-=.25f;

        }
        //timer -= Time.deltaTime;
        else if (timer <= 0f)
        {
            isDestroyed = true;
          Destroy(gameObject);
        }
        else
        {
        //    Debug.Log(pos1.x);

            float t = .5f;
            if (pos1.x < 6.53f && pos1.x > -6.53f)
            {
                if (flag == false)
                {
                    pos1.x += .05f;
                }
                else
                {
                    pos1.x -= .05f;
                }

            }
            else if (pos1.x >= 6.53f)
            {
                pos1.x = 6.51f;
                flag = true;

            }
            else if (pos1.x <= -6.53f)
            {
                pos1.x = -6.51f;
                flag = false;

            }
            

        }
        transform.position = pos1;


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "playerbullet")
        {
            someting.Play();
            enemyExplosion();
            Destroy(gameObject);
            Destroy(other.gameObject);

        }
    }
    void enemyExplosion() {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        explosion.transform.position = transform.position;

    }
}
