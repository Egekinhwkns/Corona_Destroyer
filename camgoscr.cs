using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class camgoscr : MonoBehaviour
{
    private float speed = 850f;

    public float sayac = 0f;

    public float sayac2 = 0f;
    // Start is called before the first frame update
    private void Update()
    {
        if (FindObjectOfType<ballMovement>().crushed3)
        {
            if (sayac == 0f)
            {
                
                if (sayac2 == 0f)
                {
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 180f),
                        Time.deltaTime * speed);
                    if (transform.rotation.eulerAngles.z==180f)
                    {
                        sayac2++;
                    }
                }
                else if (sayac2 == 1f)
                {
                
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 359f),
                        Time.deltaTime * speed);
                    if (transform.rotation.eulerAngles.z==359f)
                    {
                        sayac2++;
                    }
                }
                else
                {
                  
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 90),
                        Time.deltaTime * speed);
                    if (transform.rotation.eulerAngles.z==90f)
                    {
                        sayac2 = 0f;
                        FindObjectOfType<ballMovement>().crushed3 = false;
                        sayac++;
                    }
                }
                
            }
            else if (sayac == 1f)
            {
                if (sayac2 == 0f)
                {
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 270f),
                        Time.deltaTime * speed);
                    if (transform.rotation.eulerAngles.z==270f)
                    {
                        sayac2++;
                    }
                }
                else if (sayac2 == 1f)
                {
                
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 90f),
                        Time.deltaTime * speed);
                    if (transform.rotation.eulerAngles.z==90f)
                    {
                      
                        sayac2++;
                    }
                }
                
                else
                
                {
                 
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 180),
                        Time.deltaTime * speed);
                    if (transform.rotation.eulerAngles.z==180f)
                    {
                        sayac2 = 0f;
                        FindObjectOfType<ballMovement>().crushed3 = false;
                        sayac++;
                    }
                }
            }
            else if (sayac == 2f)
            {
                if (sayac2 == 0f)
                {
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 359f),
                        Time.deltaTime * speed);
                    if (transform.rotation.eulerAngles.z==359f)
                    {
                        sayac2++;
                    }
                }
                else if (sayac2 == 1f)
                {
                
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 180f),
                        Time.deltaTime * speed);
                    if (transform.rotation.eulerAngles.z==180f)
                    {
                        
                        sayac2++;
                    }
                }
                else
                {
                   
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 270),
                        Time.deltaTime * speed);
                    if (transform.rotation.eulerAngles.z==270f)
                    {
                        sayac2 = 0f;
                        FindObjectOfType<ballMovement>().crushed3 = false;
                        sayac++;
                    }
                }
            }
            else
            {
                if (sayac2 == 0f)
                {
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 90f),
                        Time.deltaTime * speed);
                    if (transform.rotation.eulerAngles.z==90f)
                    {
                        sayac2++;
                    }
                }
                else if (sayac2 == 1f)
                {
                
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 270f),
                        Time.deltaTime * speed);
                    if (transform.rotation.eulerAngles.z==270f)
                    {
                       
                        sayac2++;
                    }
                }
                else
                {
                   
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 359),
                        Time.deltaTime * speed);
                    if (transform.rotation.eulerAngles.z==359f)
                    {
                        sayac2 = 0f;
                        FindObjectOfType<ballMovement>().crushed3 = false;
                        sayac = 0f;
                    }
                }
            }
            
        }
        
    }
}
