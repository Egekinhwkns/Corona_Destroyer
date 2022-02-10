using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.SceneManagement;

public class ballMovement : MonoBehaviour
{
    public float health = 50f;
    private float runSpeed=15f;
    public Transform BallTransform;
    public Rigidbody2D rb;
    public bool grounded = false;
    private float jumpForce = 3f;
    private float maxSpeed = 25f;
    public bool jumped = false;
    public bool crushed = false;
    public bool crushed2 = false;
    public bool crushed3 = false;
    public float rotateSayac = 0f;
    private float crushedTime = 1.5f;
    private float firstTime = 0f;
    private float scoreTime = 0f;
    float speedTime = 0f;
    private float hpHitTime = 0f;
    private bool leftpres = false;
    private bool rightpres = false;
    private bool downpres;
    public float speedscore = 0f;
    void Update()
    {

        if (health<=0f)
        {
            FindObjectOfType<endGane>().theEnd();
        }
        hpHitTime += Time.deltaTime;
        if (maxSpeed==60f)
        {
            speedTime += Time.deltaTime;
            if (speedTime>=5f)
            {
                FindObjectOfType<ballIns>().speedcolor = false;
                maxSpeed = 25f;
                speedTime = 0f;
            }
        }
        
        firstTime += Time.deltaTime;
        if (rightpres)
       {
           rb.AddForce(transform.right*runSpeed*Time.deltaTime,ForceMode2D.Impulse);
       }

       if (leftpres)
       {
           rb.AddForce(transform.right*-1f*runSpeed*Time.deltaTime,ForceMode2D.Impulse);
       }

       if (downpres)
       {
           rb.AddForce(transform.up*-1f*runSpeed*Time.deltaTime,ForceMode2D.Impulse);
       }
       if (crushed)
        {
                rotateSayac++;
                Vector3 ballrot = new Vector3(rb.transform.rotation.x,rb.transform.rotation.y,rb.transform.rotation.z + 90f);
                rb.transform.Rotate(ballrot);
                crushed = false;
        }

        if (rotateSayac == 0f)
        {
            Physics2D.gravity = new Vector2(0,-9.8f);
            float capVelocity = Mathf.Min(Math.Abs(rb.velocity.x), maxSpeed)*Mathf.Sign(rb.velocity.x);
            rb.velocity = new Vector2(capVelocity,rb.velocity.y);
        }
        else if (rotateSayac == 1f )
        {
            Physics2D.gravity=new Vector2(9.8f,0);
            float capVelocity = Mathf.Min(Math.Abs(rb.velocity.y), maxSpeed)*Mathf.Sign(rb.velocity.y);
            rb.velocity = new Vector2(rb.velocity.x,capVelocity);
        }
        else if (rotateSayac == 2f)
        {
            Physics2D.gravity=new Vector2(0f,9.8f);
            float capVelocity = Mathf.Min(Math.Abs(rb.velocity.x), maxSpeed)*Mathf.Sign(rb.velocity.x);
            rb.velocity = new Vector2(capVelocity,rb.velocity.y);
        }
        else if (rotateSayac == 3f)
        {
            Physics2D.gravity=new Vector2(-9.8f,0);
            float capVelocity = Mathf.Min(Math.Abs(rb.velocity.y), maxSpeed)*Mathf.Sign(rb.velocity.y);
            rb.velocity = new Vector2(rb.velocity.x,capVelocity);
        }
        else
        {
            rotateSayac = 0f;
        }
    }
    

    public void jump()
    {
        if (grounded)
        {
            jumped = true;
            FindObjectOfType<AudioManager>().Play("boing1");
            rb.AddForce(rb.transform.up*jumpForce,ForceMode2D.Impulse);
        }
    }

    public void goRight()
    {
        rightpres = true;
        // rb.AddForce(transform.right*runSpeed*Time.deltaTime,ForceMode2D.Impulse);
    }
    public void goLeft()
    {
        leftpres = true;
        //   rb.AddForce(transform.right*-1f*runSpeed*Time.deltaTime,ForceMode2D.Impulse);
    }

    public void stopRight()
    {
        rightpres = false;
    }

    public void stopLeft()
    {
        leftpres = false;
    }
    public void goDown()
    {
        downpres = true;
    }

    public void stopDown()
    {
        downpres = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name.Equals("enemyColl2"))
        {
            speedscore = (rb.velocity.x * rb.velocity.x) + (rb.velocity.y * rb.velocity.y);
            speedscore = Mathf.Sqrt(speedscore) / 5f;
        }

        if (other.tag.Equals("teleportPlace"))
        {
            FindObjectOfType<endGane>().canGoNext = true;
            FindObjectOfType<endGane>().theEnd();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag.Equals("EnemyBall"))
        {
            if (crushedTime<firstTime)
            {
                crushed = true;
                crushed2 = true;
                crushed3 = true;
                firstTime = 0f;
            }
        }

        else if (other.gameObject.tag.Equals("fasterGo"))
        {
            FindObjectOfType<ballIns>().speedcolor = true;
            maxSpeed = 60f;
        }
        
        else if (other.collider.tag.Equals("bossparts"))
        {
            if (other.collider.gameObject.GetComponent<bossParts>().TakeDamage && hpHitTime>1f)
            {
                FindObjectOfType<bossscr>().healtBar -= 10f;
                hpHitTime = 0f;
            }
            else if(!other.collider.gameObject.GetComponent<bossParts>().TakeDamage)
            {
                health -= 10f;
            }
        }
    }
}
