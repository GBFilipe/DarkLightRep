using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    bool IsOnGround = true;

    //movement public float
    float moveSpeed = 7f;

    //jumping public float
    float jumpForce = 7f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move player right to left and jump
       
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);


        if (Input.GetButtonDown("Jump")&& IsOnGround)
        {
            Jump();
    
        }   }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce);
    
    
    }
    
    
    
    void OnCollisionEnter(Collision collision)
        {
            IsOnGround = true;
        }

    private void OnCollisionExit(Collision collision)
    {
       IsOnGround = false;
    }
} 

