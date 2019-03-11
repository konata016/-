using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimJump : MonoBehaviour {

    bool judge = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Stage")
        {
            judge = true;
        }
        else
        {
            judge = false;
        }

        if (judge)
        {

        }
    }
    private void OnTriggerExit(Collider other)
    {
        judge = false;
    }
    public bool getJudge()
    {
        return judge;
    }
}
