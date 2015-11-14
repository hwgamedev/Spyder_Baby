using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

    //activates when the player object collides with the object this scipt is applied to

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("It has colided");
    }
}
