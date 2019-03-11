using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowPlayer : MonoBehaviour
{

    public GameObject pl;
    float x = 0, y = 0;
    float r;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //x = Mathf.Cos(transform.localEulerAngles.x * Mathf.Deg2Rad) *
        //            Vector3.Distance(pl.transform.position, transform.position);

        //y = Mathf.Sin(transform.localEulerAngles.x * Mathf.Deg2Rad) *
        //    Vector3.Distance(pl.transform.position, transform.position);

        //pl.transform.position = new Vector3(x, y, 0) + transform.position;
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "PL")
        {
            //x = Mathf.Cos(transform.localEulerAngles.x * Mathf.Deg2Rad) *
            //     Vector3.Distance(pl.transform.position, transform.position);

            //y = Mathf.Sin(transform.localEulerAngles.x * Mathf.Deg2Rad) *
            //    Vector3.Distance(pl.transform.position, transform.position);

            //pl.transform.position = new Vector3(x, y, 0) + transform.position;


            Vector3 childPostion = transform.position;
            float angle = transform.localEulerAngles.x * Mathf.Deg2Rad;
            //childPostion.x += Vector3.Distance(pl.transform.position, transform.position) * Mathf.Cos(angle);
            childPostion.y += Vector3.Distance(pl.transform.position, transform.position) * Mathf.Sin(angle);

            if (transform.localEulerAngles.x < 270f && transform.localEulerAngles.x > 90)
            {
                childPostion.x += Vector3.Distance(pl.transform.position, transform.position) * Mathf.Cos(angle);
                Debug.Log("aaaaaaaaaaaa");
            }
            else
            {
                childPostion.x += Vector3.Distance(pl.transform.position, transform.position) * Mathf.Cos(angle);
            }
            // Debug.Log(transform.localEulerAngles.x);
            pl.transform.position = childPostion;
            // }
        }
    }
}
