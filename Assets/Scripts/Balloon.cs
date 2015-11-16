using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Balloon : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if ((transform.position.y - Camera.current.transform.position.y) > 7) {
            transform.Translate((0-transform.position.x)+ Random.Range(-8.0F, 8.0F), -15,0);
        }
    }
}