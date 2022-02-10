using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossscr : MonoBehaviour
{
    public float healtBar=100f;

    public float changeTime = 0f;
    public float bossSpeed = 20f;
    public bool canGo = false;
    public GameObject col;

    void Update()
    {
        changeTime += Time.deltaTime;
        if (healtBar<=0f)
        {
            Debug.Log("boss öldü");
            col.SetActive(false);
            //Destroy(gameObject);
        }

        if (changeTime>5f && canGo)
        {
            Vector2 path = new Vector2(UnityEngine.Random.Range(-1,1),UnityEngine.Random.Range(-1,1));
            gameObject.GetComponent<Rigidbody2D>().AddForce(bossSpeed*path,ForceMode2D.Impulse);
            changeTime = 0f;
        }
        
    }
}
