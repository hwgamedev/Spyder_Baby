using UnityEngine;

public class Player : MonoBehaviour {

    public static float distanceTraveled;
    public Vector2 startPosition;

	// Use this for initialization
	private void Start () {
         startPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        distanceTraveled = transform.localPosition.y;

        transform.Translate(0f, (-5f) * Time.deltaTime, 0f);

//        if (Player.distanceTraveled < -110)
 //       {
 //           Time.timeScale = 0.0F;
  //          var textArea = new Rect(0, 0, Screen.width, Screen.height);
  //          GUI.Label(textArea, "YOU WIN!!!");
  //      }

    }


    private void FixedUpdate() {

        if (Input.GetKey("left")){
            transform.Translate((-7.5f) * Time.deltaTime, 0f, 0f);
            //gameObject.GetComponent<SpriteRenderer>().color = Color.green; //test to show movement on game screen
        }
        else if (Input.GetKey("right")){
            transform.Translate((7.5f) * Time.deltaTime, 0f, 0f);
            //gameObject.GetComponent<SpriteRenderer>().color = Color.cyan; //test to show movement on game screen

        }

        //X axis
        if (transform.position.x <= -9){
            transform.position = new Vector2(-9f, transform.position.y);
        }
        else if (transform.position.x >= 8.4f){
            transform.position = new Vector2(8.5f, transform.position.y);
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        die();
    }

    private void die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}
