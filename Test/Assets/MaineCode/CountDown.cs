using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{

    public float timer = 300;
    public Text text;
    public Text clear;
    bool end = false;


    int wait = 20;

    // Update is called once per frame
    void Update()
    {
        if (end == false)
        {
            timer -= Time.deltaTime;
            text.text = "Time:" + timer.ToString("f2");
        }
        else
        {
            clear.text = "ＣＬＥＡＲ";
            wait -= 1;
            if (wait == 0)
            {
                SceneManager.LoadScene("MenuScene");
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ClearObject")
        {
            end = true;
        }
    }
}
