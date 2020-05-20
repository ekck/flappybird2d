using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    // movemnt speed
    public float speed = 2;

    //flap force
    public float force = 300;

    // Start is called before the first frame update
    void Start()
    {
        // fly towards the right 
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        //flap
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } 
}
