using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public Camera camera;
    public GameObject camgo;
    private float shakeAmount = 0.15f;
    
    

    public Transform circle;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    

    // Update is called once per frame
    void Update()
    {
        Vector3 moveCamera = new Vector3(circle.position.x,circle.position.y,circle.position.z-20f);
        camgo.transform.localPosition = moveCamera;
        if (FindObjectOfType<ballMovement>().crushed2)
        {
            FindObjectOfType<slowMotion>().doSlowMotion();
            FindObjectOfType<ballMovement>().crushed2 = false;
        }

        if (FindObjectOfType<ballMovement>().crushed3)
        {
            camgo.transform.localPosition = camgo.transform.localPosition + UnityEngine.Random.insideUnitSphere * shakeAmount;
        }
        
        if(FindObjectOfType<ballMovement>().grounded  && !FindObjectOfType<ballMovement>().jumped)
        {
            camera.orthographicSize = Mathf.MoveTowards(camera.orthographicSize, 10f, 20f * Time.deltaTime);
        }
        else if (!FindObjectOfType<ballMovement>().grounded)
        {
            camera.orthographicSize = Mathf.MoveTowards(camera.orthographicSize, 30f, 20f*Time.deltaTime);
          
        }
        
    }

    
    
}
