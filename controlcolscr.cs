using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlcolscr : MonoBehaviour
{
    public GameObject bosshb;
    public GameObject go;
    public GameObject bullet;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("MainBall"))
        {
            Invoke("makeVisible",1.5f);
            bosshb.SetActive(true);
            FindObjectOfType<bossscr>().canGo = true;
            go.SetActive(false);
            bullet.SetActive(true);
        }
    }

    void makeVisible()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
