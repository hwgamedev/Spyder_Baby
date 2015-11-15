/*using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Balloon : MonoBehaviour
{
    public int numberofballoons;
    public Transform prefab;

    private Vector2[] Existingballs;

    // Use this for initialization
    private void Start()
    {
        for (int i = 0; i < numberofballoons; i++)
        {
            Instantiate(prefab, new Vector2(3, (Camera.current.transform.position.y) - 10), Quaternion.identity);

        }
    }

    // Update is called once per frame
    private void Update()
    {
        for (int i = 0; i < numberofballoons; i++)
        {
            // Existingballs[i];
            [] findobjs = FindObjectsOfType(typeof) as object type[];


            {
                if ((Existingballs[i].y - Camera.current.transform.position.y) > 5)
                {
                    Debug.Log("It's out of frame, bring it down.");
                    Existingballs[i].y = (Existingballs[i].y - 10);
                }
            }
        }
    }
}
*/