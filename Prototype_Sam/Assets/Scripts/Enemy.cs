using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject playersprite;
    public float speed;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, playersprite.transform.position); //gets the distance from player to enemy
        Vector2 direction = playersprite.transform.position - transform.position;

        /*if( distance <= 4)
        {

        }*/

        transform.position = Vector2.MoveTowards(this.transform.position, playersprite.transform.position, speed * Time.deltaTime);

    }
}
