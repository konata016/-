using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

    public GameObject PL;
    public GameObject PL2;

    public float
        x = 1.8f,
        y = 12.0f,
        z = -54.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    private void OnCollisionEnter(Collision collision)
    {
        PL.gameObject.transform.position = new Vector3(x, y, z);
        PL2.gameObject.transform.position = new Vector3(x, y, z);
    }
}
