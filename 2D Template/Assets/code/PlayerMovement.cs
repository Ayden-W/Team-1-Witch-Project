using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float activeMoveSpeed;
    public float moveSpeed;
    public Rigidbody2D rb2D;
    private Vector2 moveInput;
    

    //Keycodes
    public KeyCode Up;
    public KeyCode left;
    public KeyCode right;
    public KeyCode down;
    public KeyCode PlayerInteract;

    //Bools
    public bool isFacingRight;


    //Animations
    public Animator anim;


    private void Start()
    {
        activeMoveSpeed = moveSpeed;
    }


    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();
        rb2D.velocity = moveInput * activeMoveSpeed;

        if (Input.GetKey(left))
        {

            isFacingRight = false;

        }
        if (Input.GetKey(right))
        {
            isFacingRight = true;
        }
        if (Input.GetKey(Up))
        {
           
        }
        if (isFacingRight == false)
        {
            GetComponent<SpriteRenderer>().flipY = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipY = false;
        }

        //if (Collision.collider.CompareTag(""))
        
            if (Input.GetKey(PlayerInteract))
            {
                Interact();
            }
        



        static void Interact()
        {

        }

    }
}