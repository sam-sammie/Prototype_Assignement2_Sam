using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int health;
    public int maxHealth = 30;
    public float speed;
    
    public Rigidbody2D rb;
    private Vector2 moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        rb = GetComponent<Rigidbody2D>();
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

        moveVelocity = rb.velocity;

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }



    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OnCollisonEnter");
        
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("OnCollisonStay");

    }


}
