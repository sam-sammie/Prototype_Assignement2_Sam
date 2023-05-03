using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int health;
    private float speed = 10;
    
    //public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        health = Random.Range(50, 100);
    }

    // Update is called once per frame
    void Update()
    {
        // Moving the cube with WASD
        Vector3 pos = transform.position;

        if(Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
        // Moving the cube with WASD


    }
}
