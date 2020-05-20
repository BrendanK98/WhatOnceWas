using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class charMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator ar;

    public float speed = 1f;
    public float horizontal;
    public float forceJump = 150f;
    public int health = 3;
    public int maxHealth = 5;
    public bool interacting;

    private void Start()
    {
        health = maxHealth;
        rb = GetComponent<Rigidbody2D>();
        ar = GetComponent<Animator>();
    }

    private void Update()
    {
        if (interacting == false)
            horizontal = Input.GetAxisRaw("Horizontal");

        //if (rb.velocity.y < 0)
        //    ar.SetBool("jump", false);

        //if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        //    Jump();

        Flip();
        
    }

    //private void Jump()
    //{
    //    isGrounded = false;
    //    rb.AddForce(Vector2.up * forceJump);
    //    ar.SetBool("jump", true);
    //    //ar.SetBool("fall", false);
    //}

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        ar.SetFloat("Speed", Mathf.Abs(horizontal));
    }

    private void Flip()
    {
        Vector3 theScale = transform.localScale;

        if (horizontal > 0 && theScale.x < 0)
        {
            
            theScale.x = theScale.x * -1;
        }
        else if (horizontal < 0 && theScale.x > 0)
        {
            
            theScale.x = theScale.x * -1;
        }
        transform.localScale = theScale;
    }

    //private void OnTriggerStay2D(Collider2D collider)
    //{
    //    if (collider.CompareTag("Surface") || collider.CompareTag("topSide"))
    //    {
    //        isGrounded = true;
    //        //ar.SetBool("fall", true);
    //    }
    //}
    ////Health for upcoming enemies
    //public void TakeDamage(int dmgPlayer)
    //{
    //    health -= dmgPlayer;
    //    if (health <= 0)
    //    {
    //        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    //    }
    //}
}