using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCamera : MonoBehaviour {

	public GameObject PL;

	// Use this for initialization
	void Start ()
    {
        gameObject.transform.Rotate(90, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camera = this.transform.position;

        camera.x = PL.transform.position.x;
        camera.y = PL.transform.position.y + 50;
        camera.z = PL.transform.position.z;

        transform.position = camera;

    }
}