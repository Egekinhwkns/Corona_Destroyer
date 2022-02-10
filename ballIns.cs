using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class ballIns : MonoBehaviour
{
    public GameObject go;
    public Transform mainBall;
    private float time = 0f;
    public float spawnCounter = 0f;
    private float ballLim=200f;
    public bool canSpawn = true;
    public float chaserLim = 1f;
    public bool chaserCanSpawn = false;
    public GameObject FasterGo;
    private float fasterTime = 0f;
    public bool speedcolor = false;
    public Light2D lt;
    void FixedUpdate()
    {

        
        
        if (speedcolor)
        {
            lt.color=Color.white;
        }
        else
        {
            lt.color=Color.red;
        }
        
        fasterTime += Time.deltaTime;
        if (fasterTime>10f)
        {
            fasterSpawn();
            fasterTime=0f;
        }
        time += Time.deltaTime;
        if (GameObject.FindGameObjectsWithTag("EnemyBall").Length < ballLim && time>1f && canSpawn)
        {
            spawn();
        }

        if (GameObject.FindGameObjectsWithTag("chaser").Length < chaserLim)
        {
            chaserCanSpawn = true;
        }
        else
        {
            chaserCanSpawn = false;
        }
    }
    void spawn()
    {
        if (SceneManager.GetActiveScene().buildIndex==1 && !FindObjectOfType<endGane>().complete)
        {
            Vector2 yer = new Vector2(UnityEngine.Random.Range(-50f, 55f), UnityEngine.Random.Range(-70f, 70f));
            Instantiate(go, yer, Quaternion.identity);
            spawnCounter++;
            time = 0f;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2 && !FindObjectOfType<endGane>().complete)
        {
            Vector2 yer = new Vector2(UnityEngine.Random.Range(-42f, 80f), UnityEngine.Random.Range(315f, 560f));
            Instantiate(go, yer, Quaternion.identity);
            spawnCounter++;
            time = 0.5f;
        }
    }

    void fasterSpawn()
    {
                if (SceneManager.GetActiveScene().buildIndex==1 && !FindObjectOfType<endGane>().complete)
                {
                    Vector2 yer = new Vector2(UnityEngine.Random.Range(-50f, 55f), UnityEngine.Random.Range(-70f, 70f));
                    Instantiate(FasterGo, yer, Quaternion.identity);
                }
                else if (SceneManager.GetActiveScene().buildIndex == 2 && !FindObjectOfType<endGane>().complete)
                {
                    Vector2 yer = new Vector2(UnityEngine.Random.Range(-42f, 80f), UnityEngine.Random.Range(315f, 560f));
                    Instantiate(FasterGo, yer, Quaternion.identity);
                }
    }
}
