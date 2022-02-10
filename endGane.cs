using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endGane : MonoBehaviour


{
    public bool canGoNext = false;
    public GameObject failedd;
    public bool complete=false;
    public GameObject goNext;
  
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("MainBall"))
        {
           theEnd();
        }
    }

    public void theEnd()
    {
        Cursor.lockState = CursorLockMode.Confined;
        complete = true;
        failedd.SetActive(true);
        if (!canGoNext)
        {
            goNext.SetActive(false);
        }
    }
    
}
