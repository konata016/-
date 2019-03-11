using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {

    public GameObject MainCam;
    public GameObject SubCam;

    bool KeyLock = false;

    // Use this for initialization
    void Start () {
        
        SubCam.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Q) && KeyLock == false)
        {

            if (MainCam.activeSelf)
            {
                MainCam.SetActive(false);
                SubCam.SetActive(true);
                
            }
            else
            {
                MainCam.SetActive(true);
                SubCam.SetActive(false);
            }
            KeyLock = true;
        }
        else if (Input.GetKey(KeyCode.Q) == false)
        {
            KeyLock = false;
        }
    }
}
