using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Movemment speed (0 means don't move )
    public float speed = 0;

    // Switch movement direction every x seconds 
    public float switchTime = 2;

    // Start is called before the first frame update
    void Start()
    

    {
        // initial Movement Direction
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

        //Switch every few seconds
        InvokeRepeating("Switch", 0, switchTime);
    }

    // Update is called once per frame
    void Switch()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;
        
    }
}
