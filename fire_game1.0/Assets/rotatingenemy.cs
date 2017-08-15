using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingenemy : MonoBehaviour {

    bool clock = false;
    float roraterate;
    float speed = 1f;
    float maxRotation = 30f;
    public GameObject ExplosionGO;
    public AudioSource someting;



    int live = 10;

    private GameObject beams_10,beams_111;
    public GameObject a;
    /// <summary>
    /// ////////////////
    /// </summary>

    
    // Use this for initialization
    void Start () {
        
        Vector3 pos3 = transform.position;
        pos3.x = transform.position.x;
        pos3.y = transform.position.y+2f;

        Instantiate(a, pos3, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.rotation = Quaternion.Euler(0f, 0f, maxRotation * Mathf.Sin(Time.time * speed));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "playerbullet")
        {
            if (live == 0)
            {
                someting.Play();
                enemyExplosion();
                Destroy(a);
                Destroy(gameObject);

                relativeRotate.instance.isDestroy = true;
                //beams_111 = GameObject.Find("beams_111");
                //beams_111 = GameObject.Find("beams_42");
               // Destroy(beams_10);
               // Destroy(beams_111);
            }
            else live--;

        }
    }
    void enemyExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        explosion.transform.position = transform.position;

    }
   
}

