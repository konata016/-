using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixChildRotation : MonoBehaviour
{
    int frg = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
            frg = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, -90, 0);
            frg = 1;
        }
        if (frg==0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (frg == 1)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        

    }
}
