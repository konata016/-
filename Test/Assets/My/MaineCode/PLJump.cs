using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLJump : MonoBehaviour
{

    bool judge = false;

    

    private void OnTriggerStay(Collider other)
    {
        //Vector3 jump = this.transform.position;

        //jump.x = PL.transform.position.x;
        //jump.y = PL.transform.position.y - 0.5f;
        //jump.z = PL.transform.position.z;

        //transform.position = jump;


        //Debug.Log(judge);
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
