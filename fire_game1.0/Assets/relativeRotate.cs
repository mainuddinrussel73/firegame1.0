using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relativeRotate : MonoBehaviour
{

    private float RotateSpeed = 1f;
    private float Radius = 1.5f;

    private Vector3 _centre;
    private float _angle;
    public bool isDestroy = false;
    public static relativeRotate instance;
    private float qfireDelay = 3.5f;
    float qcoolDownTimer = 3.4f;
    public GameObject beams_10, beams_111;
    float maxRotation = 5f;
    // Use this for initialization
    void Start()
    {
        instance = this;
        _centre.x = transform.position.x;
        _centre.y = transform.position.y-1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDestroy == true) {
            Destroy(gameObject);
        }
       
        _angle += (RotateSpeed * Time.deltaTime);
        float x = Mathf.Sin(_angle);
        float y = Mathf.Sqrt(Radius*Radius-x*x);
        y = -y;
        var offset = new Vector3(x,y)*Radius;
            //if (chap > maxRotation) { offset.x -= maxRotation;offset.y -= maxRotation; }
        transform.position = _centre + offset;
        //flag = false;

        Vector3 pos4 = transform.position;
        //Vector3 pos5 = transform.position;
        qcoolDownTimer -= Time.deltaTime;
        //Vector3 pos5 = transform.position;
        Vector3 pos3 = transform.position;

        if (qcoolDownTimer <= 0)
        {

            //Debug.Log("dew!!!");
            qcoolDownTimer = qfireDelay;

            pos3.x = transform.position.x - .7f;
            pos3.y = transform.position.y - .4f;

            pos4.x = transform.position.x + .7f;
            pos4.y = transform.position.y - .4f;

            //      pos5.x = transform.position.x;
            //    pos5.y = transform.position.y - 1.94f;

            Instantiate(beams_10, pos3, transform.rotation);
            Instantiate(beams_111, pos4, transform.rotation);



        }
        }

}