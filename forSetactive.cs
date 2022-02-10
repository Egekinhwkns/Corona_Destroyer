using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forSetactive : MonoBehaviour
{
    public Transform ball;
    
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2 && ball.position.y > 300f && gameObject.GetComponent<ballIns>().enabled == false) 
        {
            gameObject.GetComponent<ballIns>().enabled = true;
            
        }
        else if(SceneManager.GetActiveScene().buildIndex==2 && gameObject.GetComponent<ballIns>().enabled == true && ball.position.y<270f )
        {
            gameObject.GetComponent<ballIns>().enabled = false;
            
            
            
        }
    }
}
