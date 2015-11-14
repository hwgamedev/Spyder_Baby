using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}


    void FixedUpdate() {
        movement();             //moves player left and right;
    }
    
    void movement() {
        if (Input.GetKey("left"))
        {
            transform.Translate((-40f) * Time.deltaTime, 0f, 0f);
            gameObject.GetComponent<SpriteRenderer>().color = Color.green; //test to show movement on game screen

        }
        else if (Input.GetKey("right"))
        {
            transform.Translate((40f) * Time.deltaTime, 0f, 0f);
            gameObject.GetComponent<SpriteRenderer>().color = Color.black; //test to show movement on game screen

        }
    }
}
