using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using Random = System.Random;



public class EnemyBallScript : MonoBehaviour
{
    public GameObject go;
    private float throwSpeed = 3f;
    public ParticleSystem partikıl;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("MainBall"))
        {
            FindObjectOfType<score>().scoreHesap();
            FindObjectOfType<AudioManager>().Play("boing2");
            Destroy(go);
            if (FindObjectOfType<ballMovement>().health<=45f)
            {
                FindObjectOfType<ballMovement>().health += 5f;
            }
            Instantiate(partikıl, go.transform.position, Quaternion.identity);
            float way1 = UnityEngine.Random.Range(-2,2);
            float way2 = UnityEngine.Random.Range(2,2);
            Vector2 throwit = new Vector2(way1,way2);
            FindObjectOfType<ballMovement>().rb.AddForce(throwit*throwSpeed,ForceMode2D.Impulse);
            
        }
    }
}
