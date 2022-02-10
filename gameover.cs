using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public GameObject cnvs1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("MainBall"))
        {
            FindObjectOfType<endGane>().theEnd();
            cnvs1.SetActive(true);
        }
    }
}
