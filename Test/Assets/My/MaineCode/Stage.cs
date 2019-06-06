using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour {

    public float roll = 0f;
    bool key_lock = false;

    public float speed = 3f;

    private Quaternion qr;

    // Use this for initialization
    void Start () {
        qr = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        //roll = 0f;
        float step = speed * Time.deltaTime;


        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.X)) ;
        else {
            key_lock = false;
        }

        if (Input.GetKey(KeyCode.Z) && key_lock == false)
        {
            roll += 90f;
            key_lock = true;
        }
        if (Input.GetKey(KeyCode.X) && key_lock == false)
        {
            roll -= 90f;
            key_lock = true;
        }


        //gameObject.transform.Rotate(roll, 0, 0);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(roll, 90, 0), step);

    }
}

//addforce addlotate これつかって
