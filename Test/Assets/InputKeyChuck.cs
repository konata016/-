using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;

public class InputKeyChuck : MonoBehaviour
{
    public Text Txt;

    // Start is called before the first frame update
    void Start()
    {
        Txt.text = "入力:";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            foreach (KeyCode Code in Input.inputString)
            {
                Txt.text = "入力:" + Code;
            }
        }
        else Txt.text = "入力:";
    }
}
