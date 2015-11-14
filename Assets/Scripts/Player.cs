﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public static float distanceTraveled;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        distanceTraveled = transform.localPosition.y;

        transform.Translate(0f, (-5) * Time.deltaTime, 0f);

    }


    void FixedUpdate() {
        if (Input.GetKey("left"))
        {
            transform.Translate((-15f) * Time.deltaTime, 0f, 0f);
            gameObject.GetComponent<SpriteRenderer>().color = Color.green; //test to show movement on game screen


        }
        else if (Input.GetKey("right"))
        {
            transform.Translate((15f) * Time.deltaTime, 0f, 0f);
            gameObject.GetComponent<SpriteRenderer>().color = Color.cyan; //test to show movement on game screen

        }

        if (transform.position.x <= 5.0){
            transform.position = new Vector2(-4.3f, transform.position.y);
        }


    }
}