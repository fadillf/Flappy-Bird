using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipaMovement : MonoBehaviour
{
    Vector2 end = new Vector2(-20, 0);
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(-20, transform.position.y), speed * Time.deltaTime);
        if (transform.position.x == end.x)
        {
            Destroy(gameObject);
        }
    }
}
