using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class chaserscr : MonoBehaviour
{
    private Transform target;
    private float speed = 7f;
    public ParticleSystem partikıl;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("MainBall").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("MainBall"))
        {
            FindObjectOfType<ballMovement>().health -= 25f;
        }
            Instantiate(partikıl,transform.position, Quaternion.identity);
            Destroy(this.gameObject);
    }
}
