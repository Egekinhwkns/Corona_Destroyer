using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Color = System.Drawing.Color;

public class bossParts : MonoBehaviour
{
    private float time = 0f;
    public bool TakeDamage = false;
    public GameObject bullet;
    public Transform bulletPlace;
    public Transform goplace;
    private float bulletSpeed = 70f;
    public ParticleSystem partikıl;
    public ParticleSystem partikıl2;
    private void FixedUpdate()
    {

        time += Time.deltaTime;
        if (time>3f)
        {
            float a = UnityEngine.Random.Range(0, 2);
            time = 0f;
            if (a==0)
            {
                 gameObject.GetComponent<SpriteRenderer>().color= new Color32(114, 255, 64, 255);
                 TakeDamage = true;
            }
            else
            {
                TakeDamage = false;
                gameObject.GetComponent<SpriteRenderer>().color= new Color32(255, 42, 42, 255);
                GameObject b =Instantiate(bullet, bulletPlace.position, Quaternion.identity) as GameObject;
                Vector2 go = new Vector2(goplace.position.x-bulletPlace.position.x,goplace.position.y-bulletPlace.position.y);
                b.gameObject.GetComponent<Rigidbody2D>().AddForce(bulletSpeed*go,ForceMode2D.Impulse);
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("MainBall") && TakeDamage)
        {
            Instantiate(partikıl, transform.position, Quaternion.identity);
        }
        else if (other.gameObject.tag.Equals("MainBall") && !TakeDamage)
        {
            Instantiate(partikıl2, transform.position, Quaternion.identity);
        }
    }
}
