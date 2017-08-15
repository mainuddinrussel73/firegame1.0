using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroExplode : MonoBehaviour {

    public GameObject playerExplosion;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "playerbullet")
        {
            playerexplosion();
            Destroy(gameObject);
            Destroy(other.gameObject);
            
        }
    }
    void playerexplosion()
    {
       
        GameObject explosion = (GameObject)Instantiate(playerExplosion);
        explosion.transform.position = transform.position;

    }
}
