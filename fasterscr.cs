using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class fasterscr : MonoBehaviour
{
    private float sayac = 3f;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(UnityEngine.Random.Range(-25,25),UnityEngine.Random.Range(20,25)),ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag!=("MainBall"))
        {
            sayac--;
            if (sayac<=0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
