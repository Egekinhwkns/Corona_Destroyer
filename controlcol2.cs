using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlcol2 : MonoBehaviour
{
    public GameObject go;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("MainBall"))
        {
            Invoke("makeVisible",0.5f);
            go.SetActive(false);
        }
    }

    void makeVisible()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
