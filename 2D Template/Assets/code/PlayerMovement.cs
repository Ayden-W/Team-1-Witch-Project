using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private void Awake()
    {
        //if (!SceneLoader.walkedThroughDoor.GetValueOrDefault(true))
        
            //transform.position = SceneLoader.lastPostion;
        
        pickUpBag.bagsCollected = pickUpBag.transferedBags;
    }


    private void Start()
    {
        if (PrePosition.scenePosPre.ContainsKey(SceneManager.GetActiveScene().name))
        {
            transform.position = PrePosition.scenePosPre[SceneManager.GetActiveScene().name];
            Debug.Log($"Loading position in scene {SceneManager.GetActiveScene().name} at {transform.position}");
        }

        Debug.Log("same spot");
        activeMoveSpeed = moveSpeed;
        Debug.Log(pickUpBag.bagsCollected);
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
            
        }
        if (Input.GetKeyUp(Up))
        {
            anim.SetFloat("Speed", 0);
            anim.SetBool("Facing UP", true);
            anim.SetBool("IsRight", false);

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
            anim.SetBool("IsRight", false);
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