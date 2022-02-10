using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Rendering.Universal;
using Color = System.Drawing.Color;

public class yellowLightScr : MonoBehaviour
{
    public Light2D lt;
    public float healthBar = 3f;
    
    void Update()
    {
        if (healthBar<=0)
        {
            Destroy(gameObject);
            FindObjectOfType<score>().scoreNum += 150f;
        }
        else if (healthBar == 1)
        {
            lt.color=UnityEngine.Color.white;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("MainBall"))
        {
            healthBar--;
        }
    }
}
