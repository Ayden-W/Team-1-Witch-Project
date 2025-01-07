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
            anim.SetBool("IsRight", true);
            isFacingRight = false;
            anim.SetFloat("Speed",1);

        }
        if (Input.GetKeyUp(left))
        {
            anim.SetFloat("Speed",0);
            anim.SetBool("Facing UP", true);
        }
        if (Input.GetKeyUp(right))
        {
            anim.SetFloat("Speed", 0);
            anim.SetBool("Facing UP", true);
        }
        if (Input.GetKey(right))
        {
            anim.SetBool("IsRight", true);
            isFacingRight = true;
            anim.SetFloat("Speed",1);
        }
        if (Input.GetKey(Up))
        {
            anim.SetFloat("Speed",1);
            anim.SetBool("Facing UP", true);
            anim.SetBool("IsRight", false);
        }
        if (Input.GetKeyUp(Up))
        {
            anim.SetFloat("Speed", 0);
            anim.SetBool("Facing UP", true);

        }
        if (Input.GetKey(down))
        {
            anim.SetFloat("Speed", 1);
            anim.SetBool("Facing UP", false);
            anim.SetBool("IsRight", false);
        }
        if (Input.GetKeyUp(down))
        {
            anim.SetFloat("Speed", 0);
            anim.SetBool("Facing UP", false);
        }

        if (isFacingRight == false)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = true;
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