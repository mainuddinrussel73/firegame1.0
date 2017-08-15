using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;
using UnityStandardAssets.CrossPlatformInput;

public class playerMovement : MonoBehaviour
{

    [SerializeField] Transform target;
    float speed = 6f;
    Vector2 targetPos;

    public GameObject astroid;
    float launchDelay = 5.05f;
    float coolDownTimer = 0f;
    public AudioSource someting;

    float maxSpeedX;
    float maxSpeeed;
    public Text scoreText;
    //public Canvas lifes;
    int liveCounter = 10;
    Rigidbody2D rd;
    bool _isPressed = false;
    int score;
    public GameObject playerExplosion;
    float directionX;
    // Use this for initialization
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        //Transform child = transform.Find("lives");
        //scoreText = child.GetComponent<Text>();
        targetPos = transform.position;
        scoreText.text = "Lifes : 10";
        // lifes.GetComponent<Text>().text = "Please Wait, Initialising Objects.";
        //LayoutRebuilder.ForceRebuildLayoutImmediate(lifes.GetComponent<Canvas>().transform as RectTransform);
        //Canvas.ForceUpdateCanvases();
    }

    // Update is called once per frame
    void Update() {
       
        scoreText.text = "Live : " + (liveCounter);
        //rotate the ship. 
        coolDownTimer -= Time.deltaTime;

        Vector3 pos3 = transform.position;
        if (coolDownTimer <= 0)
        {
            coolDownTimer = launchDelay;

            float rendx = UnityEngine.Random.Range(-1.5f, 6.63f);
            pos3 = new Vector2(rendx, 9.04f);



            Instantiate(astroid, pos3, transform.rotation);
        }
        //Vector3 pos1 = transform.position;

        /*  if (pos1.x <= 5.8f && Input.GetAxis("Horizontal") == 1)
          {
              pos1.x += Input.GetAxis("Horizontal") * maxSpeedX * Time.deltaTime;
              transform.position = pos1;
          }
          else if (pos1.x > 5.8f)
          {
              pos1.x = 5.8f;

          }
          if (pos1.x >= -5.62f && Input.GetAxis("Horizontal") == -1)
          {
              pos1.x += Input.GetAxis("Horizontal") * maxSpeedX * Time.deltaTime;
              transform.position = pos1;
          }
          else if (pos1.x < -5.62f)
          {
              pos1.x = -5.62f;

          }
          //move the ship
          //Returns a float from -1 to +1
          */


        directionX = CrossPlatformInputManager.GetAxis("Horizontal");
        maxSpeedX = directionX * 100;
        maxSpeeed = directionX * 1000;


        if (rd.position.x >= -6.02f && rd.position.x <= 6.02f) rd.velocity = new Vector2(maxSpeedX, 0f);
        else if (rd.position.x > 6.02f) rd.position = new Vector2(6.02f, -4.58f);
        else if (rd.position.x < -6.02f) rd.position = new Vector2(-6.02f, -4.58f);
        Debug.Log(maxSpeeed);
       



    }
    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.tag == "astroid")
        {
            someting.Play();
            Destroy(other.gameObject);

            Destroy(gameObject);
            playerexplosion();
            //someting.Play();
            //score+=10;

            FindObjectOfType<Gamecontroller>().EndGame();
            //Time.timeScale = 0;

        }
        if (other.tag == "enemy" || other.tag == "enemybullet")
        {
            
            if (liveCounter == 0)
            {
                someting.Play();
                Destroy(other.gameObject);
                
                Destroy(gameObject);
                //score+=10;
                playerexplosion();
                
                FindObjectOfType<Gamecontroller>().EndGame();
                //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                //someText.text = "life left is : " + (10 - liveCounter);
                //someText.text = "Life : " + ;
            }
            liveCounter--;
        }
    }
  
    public static void EndGame() {


    }

    void playerexplosion()
    {
        liveCounter = 0;
        GameObject explosion = (GameObject)Instantiate(playerExplosion);
        explosion.transform.position = transform.position;

    }
}
