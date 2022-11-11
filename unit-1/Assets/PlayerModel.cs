using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    Rigidbody2D rb;
    bool touchingPlatform;
    float jumpVelocity = 9;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

 
    void Update()
    {
        ReadKeys();

    
   
    }

    void ReadKeys()
    {
        Vector2 vel = rb.velocity;

        if (Input.GetKey("up") && (touchingPlatform==true))
        {
       
            vel.y = jumpVelocity;
        }
        if (Input.GetKey("left"))
        {
            vel.x = -4;
        }
        if (Input.GetKey("right"))
        {
            vel.x = 4;
        }

        rb.velocity = vel;
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchingPlatform = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchingPlatform = false;
        }
    }
}
