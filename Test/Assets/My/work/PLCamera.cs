using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLCamera : MonoBehaviour
{
    public GameObject PL;


    // Use this for initialization
    void Start()
    {
        gameObject.transform.Rotate(0, 0, 0);
        transform.position = PL.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camera = transform.position;

        camera.x = PL.transform.position.x;
        camera.y = PL.transform.position.y + 5;
        camera.z = PL.transform.position.z - 20;

        transform.position = camera;

    }
}