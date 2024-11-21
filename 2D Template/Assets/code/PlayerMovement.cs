using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode Up;
    public KeyCode left;
    public KeyCode right;
    public float speed;
    public bool isFacingRight = false;
    private Rigidbody rb;
    private SpriteRenderer SpriteRenderer;
    // Update is called once per frame



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    void Update()
    {
        if (Input.GetKey(left))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
            isFacingRight = false;
            if (Input.GetKeyUp(left))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y + 3);
            }

        }
        if (Input.GetKey(right))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
            isFacingRight = true;
            
        }
        if(Input.GetKey(Up))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2( GetComponent<Rigidbody2D>().velocity.x, speed);
        }
        if (isFacingRight == false)
        {
            GetComponent<SpriteRenderer>().flipY = true;
        }
        else 
        {
            GetComponent<SpriteRenderer>().flipY = false;
        }
    }
}