using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounded : MonoBehaviour
{
    public Rigidbody2D ballRb;

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("HorizontalGround"))
        {
            FindObjectOfType<ballMovement>().grounded = true;
            FindObjectOfType<ballMovement>().jumped = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag.Equals("HorizontalGround"))
        FindObjectOfType<ballMovement>().grounded = false;
        
    }
    
}
