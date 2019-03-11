using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Title : MonoBehaviour {

    int Stage = 0;
    Text txt;

    // Use this for initialization
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //選択
        if (Input.GetKeyDown(KeyCode.DownArrow) && Stage < 2) Stage++;
        if (Input.GetKeyDown(KeyCode.UpArrow) && Stage > 0) Stage--;
        //Debug.Log(Stage);

        //移動
        switch (Stage)
        {
            case 0: txt.transform.localPosition = new Vector2(246, 70); break;
            case 1: txt.transform.localPosition = new Vector2(246, -16); break;
            case 2: txt.transform.localPosition = new Vector2(246, -100); break;
            default: break;
        }

        //決定
        if (Input.GetKey(KeyCode.Space))
        {
            switch (Stage)
            {
                case 0:SceneManager.LoadScene("MenuScene");break;
                case 1: SceneManager.LoadScene("info"); break;
                case 2: Application.Quit(); break;
                default:break;
            }
        }
    }
}
