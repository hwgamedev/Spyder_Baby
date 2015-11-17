using UnityEngine;

public class Repspawn : MonoBehaviour
{

    public float Distance_Down;

    // Update is called once per frame
    private void Update()
    {
        if (((transform.position.y - Camera.main.transform.position.y) > 7) && (Camera.main.transform.position.y > -(Distance_Down)))
        {
            transform.Translate((0 - transform.position.x) + Random.Range(-8.0F, 8.0F), -15, 0);
        }
    }
}
