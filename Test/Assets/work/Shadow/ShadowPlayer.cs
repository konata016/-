using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowPlayer : MonoBehaviour
{
    public bool OnShadow { get; set; }
    public bool OffShadow { get; set; }

    public GameObject pl;
    Vector3 childPostion;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OnShadow)
        {
            if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
            {
            }
            else
            {
                childPostion = transform.position;
                float angle = (transform.localEulerAngles.z - 90f) * Mathf.Deg2Rad;
                childPostion.x += Vector3.Distance(pl.transform.position, transform.position) * Mathf.Cos(angle);
                childPostion.y += Vector3.Distance(pl.transform.position, transform.position) * Mathf.Sin(angle);
                pl.transform.position = childPostion;
            }
        }
        if (OffShadow)
        {
            OnShadow = false;
        }
    }

}
