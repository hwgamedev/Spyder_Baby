﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, target.position.y, -10);
    }
}
