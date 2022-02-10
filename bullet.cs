using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class bullet : MonoBehaviour
{
    public ParticleSystem partikıl;
    private float time = 0f;
    private float sayac = 0f;
    private void Update()
    {
        time += Time.deltaTime;
        if (sayac>=2f)
        {
            Destroy(gameObject);
            Instantiate(partikıl, transform.position, Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("MainBall"))
        {
            if (FindObjectOfType<ballMovement>().health>=10f)
            {
                FindObjectOfType<ballMovement>().health -= 10f;
            }
            else if (FindObjectOfType<ballMovement>().health < 10f)
            {
                FindObjectOfType<ballMovement>().health = 0f;
            }
            Destroy(gameObject);
            Instantiate(partikıl, transform.position, Quaternion.identity);
        }
        else if (other.collider.tag.Equals("bossparts") && time>1f)
        {
            FindObjectOfType<bossscr>().healtBar -= 5f;
            Instantiate(partikıl, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            sayac++;
        }
    }
}
