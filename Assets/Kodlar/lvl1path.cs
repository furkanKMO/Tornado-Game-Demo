using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl1path : MonoBehaviour
{
    public GameObject gameover;
    public GameObject waypoint2;
    public GameObject waypoint3;
    public GameObject waypoint4;
    public GameObject nextlevel,firtina1;
    private AudioSource _audio;
    public AudioClip win, lose;

    int konum = 0;
    public int hiz = 10;
    
   
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        nextlevel.SetActive(false);
        gameover.SetActive(false);
    }

    void Update()
    {
        if (start.MoveAllowed)
        {


            float singleStep = 5f * Time.deltaTime;
            if (konum == 1)
            {
                firtina.carturn = false;
                Vector3 targetDirection = waypoint2.transform.position - this.transform.position;
                Vector3 newDirection = Vector3.RotateTowards(this.transform.forward, targetDirection, singleStep, 0.0f);
                Debug.DrawRay(transform.position, newDirection, Color.red);
                transform.rotation = Quaternion.LookRotation(newDirection);
                this.transform.position = Vector3.MoveTowards(this.transform.position, waypoint2.transform.position, hiz*Time.deltaTime);
                //this.transform.Translate(waypoint2.transform.position);

            }
            if (konum == 2)
            {
                waypoint2.SetActive(false);
                firtina.carturn = true;
                Vector3 targetDirection = waypoint3.transform.position - this.transform.position;
                Vector3 newDirection = Vector3.RotateTowards(this.transform.forward, targetDirection, singleStep, 0.0f);
                Debug.DrawRay(transform.position, newDirection, Color.red);
                transform.rotation = Quaternion.LookRotation(newDirection);
                this.transform.position = Vector3.MoveTowards(this.transform.position, waypoint3.transform.position, hiz * Time.deltaTime);

            }
            if (konum == 3)
            {
                waypoint3.SetActive(false);
                firtina.carturn = false;
                Vector3 targetDirection = waypoint4.transform.position - this.transform.position;
                Vector3 newDirection = Vector3.RotateTowards(this.transform.forward, targetDirection, singleStep, 0.0f);
                Debug.DrawRay(transform.position, newDirection, Color.red);
                transform.rotation = Quaternion.LookRotation(newDirection);
                this.transform.position = Vector3.MoveTowards(this.transform.position, waypoint4.transform.position, hiz * Time.deltaTime);

            }
        }
    }
    void OnTriggerEnter()
    {
        konum++;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "engel"||collision.gameObject.tag=="cylone")
        {
            _audio.clip = lose;
            _audio.Play();
            start.MoveAllowed = false;
            konum = 0;
            gameover.SetActive(true);
        }
        if (collision.gameObject.tag=="field")
        {
            _audio.clip = win;
            _audio.Play();
            firtina1.SetActive(false);
            start.MoveAllowed = false;
            nextlevel.SetActive(true);

        }
    }
}