using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteraction : MonoBehaviour
{

    public float speed;
    public ScoreScript scoreScript;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a") && transform.position.x> -8)
        {
            Vector3 move = new Vector3(-1f, 0f, 0f);
            this.transform.position += move * Time.deltaTime *speed;
        }

        if (Input.GetKey("d") && transform.position.x < 8)
        {
            Vector3 move = new Vector3(1f, 0f, 0f);
            this.transform.position += move * Time.deltaTime * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("you have been hit");
        scoreScript.UpdatePlayerLives(-1);
    }
}
