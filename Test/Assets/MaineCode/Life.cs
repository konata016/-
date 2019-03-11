using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Life : MonoBehaviour
{
    public Text life;
    int LifeCount = 3;

    // Update is called once per frame
    void Update()
    {
        //ライフ制御
        life.text = "Life:" + LifeCount.ToString();

        //ゲームオーバーシーン移動
        if (LifeCount == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "BreakObject")
        {
            LifeCount -= 1;
        }
    }
}