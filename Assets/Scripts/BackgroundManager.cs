using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackgroundManager : MonoBehaviour {
    public Transform prefab; //the cloud sprite that will be generated
    public int numberOfClouds;
    public Vector2 startPosition;
    public float recycleOffset;
    public Vector2 minSize, maxSize;

    private Vector2 nextPosition;
    private Queue<Transform> objectQueue;


	// Use this for initialization
    void Start () {
        objectQueue = new Queue<Transform>(numberOfClouds);     //generate new queue to store cloud objects for background

        for (int i = 0; i< numberOfClouds; i++) {
            objectQueue.Enqueue((Transform)Instantiate(prefab));
        }

        startPosition = nextPosition;

        for (int i = 0; i < numberOfClouds; i++){
            Recycle();
        }
    }
	
	// Update is called once per frame
	void Update () {
       // Debug.Log("cloud pos - recycle " + (objectQueue.Peek().localPosition.y - recycleOffset) + "player position " + Player.distanceTraveled);
        if (objectQueue.Peek().localPosition.y + (recycleOffset) > Player.distanceTraveled){
            Recycle();
        }

    }

    void Recycle() {
        Vector2 scale = new Vector2(
                Random.Range(minSize.x, maxSize.x),
                Random.Range(minSize.y, maxSize.y));

        Vector2 position = nextPosition;
        position.x += scale.x * 0.5f;
        position.y += scale.y * 0.5f;

        Transform o = objectQueue.Dequeue();
        o.localPosition = position;
        nextPosition.y -= o.localScale.y;
        objectQueue.Enqueue(o);
    }

}
