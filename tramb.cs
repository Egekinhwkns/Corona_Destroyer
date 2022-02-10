using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tramb : MonoBehaviour
{
    public Rigidbody2D ballRb;
    private float trambSpeed = 17f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("sides") || other.gameObject.tag.Equals("MainBall") || other.gameObject.tag.Equals("grounded"))
        {
            FindObjectOfType<AudioManager>().Play("boing3");
            ballRb.AddForce(this.gameObject.transform.up*trambSpeed,ForceMode2D.Impulse);
        }
    }
}
