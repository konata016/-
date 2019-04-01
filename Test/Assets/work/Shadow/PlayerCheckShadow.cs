using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckShadow : MonoBehaviour
{

    public bool OnShadow { get; set; }
    public bool OffShadow { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OnShadow)
        {
            GameObject.Find("UTC_Default").transform.parent = transform;
        }
        if (!OnShadow)
        {  //子オブジェクトから親オブジェクトを解除する
            GameObject.Find("UTC_Default").transform.parent = null;
        }
        if (OffShadow)
        {
            OnShadow = false;
           
        }
        
    }
}
