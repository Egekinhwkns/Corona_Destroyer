using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class squareChaser : MonoBehaviour
{
    private Rigidbody2D rbSquare;

    private void Start()
    {
      rbSquare= gameObject.GetComponent<Rigidbody2D>();
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("HorizontalGround"))
        {
          Destroy(gameObject);  
        }
    }
}
