using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorBehaviour : MonoBehaviour
{
    public float speed;
    public float bottomBounds;
    public float topBounds;


    private Vector3 move = new Vector3(0f, -1f, 0f);
    // Update is called once per frame
    void Update()
    {
        transform.position += move * Time.deltaTime * speed;

        if( transform.position.y < bottomBounds)
        {
            transform.position = new Vector3(0f, topBounds, 0f);
        }
    }
}
