using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    bool Rfrg = false, Lfrg = false;
    int Stage = 0;
    Image image;

    // Use this for initialization
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        //選択
        if (Input.GetKeyDown(KeyCode.RightArrow) && Stage < 2) Stage++;
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Stage > 0) Stage--;


        if (Input.GetKey(KeyCode.Escape)) SceneManager.LoadScene("Title");
        //Debug.Log(Stage);

        //移動
        switch (Stage)
        {
            case 0: image.transform.localPosition = new Vector2(-290, 0); break;
            case 1: image.transform.localPosition = new Vector2(0, 0); break;
            case 2: image.transform.localPosition = new Vector2(290, 0); break;
            default: break;
        }

        //決定
        if (Input.GetKey(KeyCode.Space))
        {
            switch (Stage)
            {
                case 0: SceneManager.LoadScene("Stage1"); break;
                case 1: SceneManager.LoadScene("Stage2"); break;
                case 2: SceneManager.LoadScene("Stage3"); break;
                default: break;
            }
        }
    }
}
