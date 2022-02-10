using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlaces : MonoBehaviour
{
    public GameObject chaser2;

    public float time=2f;
  
    
    void Update()
    {
        time += Time.deltaTime;
        if (gameObject.transform.position.x<65f && gameObject.transform.position.x>-43f && time>2f && FindObjectOfType<ballMovement>().rotateSayac==0)
        {
            Instantiate(chaser2, transform.position, Quaternion.identity);
            time = 0f;
        }
        else if (gameObject.transform.position.x<-43f && time>2f && FindObjectOfType<ballMovement>().rotateSayac==1)
        {
            Instantiate(chaser2, transform.position, Quaternion.identity);
            time = 0f;
        }
        else if (gameObject.transform.position.x>65f && time>2f && FindObjectOfType<ballMovement>().rotateSayac==3)
        {
            Instantiate(chaser2, transform.position, Quaternion.identity);
            time = 0f;
        }
    }
}
