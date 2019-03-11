using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowPlayer : MonoBehaviour
{
    public bool OnShadow { get; set; }

    public GameObject pl;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OnShadow)
        {
            Vector3 childPostion = transform.position;
            float angle = (transform.localEulerAngles.z - 90f) * Mathf.Deg2Rad;
            childPostion.x += Vector3.Distance(pl.transform.position, transform.position) * Mathf.Cos(angle);
            childPostion.y += Vector3.Distance(pl.transform.position, transform.position) * Mathf.Sin(angle);
            pl.transform.position = childPostion;
        }
    }

}
