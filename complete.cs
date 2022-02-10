using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class complete : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreFinalText;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    private void Update()
    {
        scoreFinalText.text = "Skorunuz : " + FindObjectOfType<score>().scoreNum.ToString("0");
    }

}
