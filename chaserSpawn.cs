using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class chaserSpawn : MonoBehaviour
{
    public GameObject chaser;
    public float time=0f;
    void Update()
    {
        time += Time.deltaTime;
        if (time>5f && FindObjectOfType<ballIns>().chaserCanSpawn)
        {
            time = 0f;
            spawnChaser();
        }
    }

    public void spawnChaser()
    {
        Instantiate(chaser, transform.position, Quaternion.identity);
    }
}
