using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;

public class colorChange : MonoBehaviour
{
    public Camera camera;

    private void Start()
    {
        camera.clearFlags = CameraClearFlags.SolidColor;
    }

    void Update()
    {
        
        float t= Mathf.PingPong (Time.time, 3f) / 3f;
       

        if (SceneManager.GetActiveScene().buildIndex==2)
        {
            if (FindObjectOfType<bossscr>().canGo)
            {
                camera.backgroundColor  = Color.Lerp (Color.black,Color.Lerp(Color.grey, Color.black, t), t);
            }
            else
            {
                camera.backgroundColor  = Color.Lerp (Color.black,Color.Lerp(Color.blue, Color.gray, t), t);
            }
        }
        else
        {
            camera.backgroundColor  = Color.Lerp (Color.black,Color.Lerp(Color.blue, Color.gray, t), t);
        }
       
    }
    
}
