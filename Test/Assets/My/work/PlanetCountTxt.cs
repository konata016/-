using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlanetCountTxt : MonoBehaviour {

    public PlaneUp s;
    public Text txt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //ライフ制御
        txt.text = "PlanetCount:" + s.PlanetCounter();
    }
}
