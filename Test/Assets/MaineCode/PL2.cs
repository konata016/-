using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL2 : MonoBehaviour
{
    public float speed = 3f;

    public PLJump JumpScript;
    public float jump_power = 100f;
   // public BoxCollider cc;
    public Rigidbody rb;

    Vector3
        def_vec = Vector3.zero,
        var_vel = new Vector3(0, 0, 1),
        hol_vel = new Vector3(1, 0, 0),
        hig_vel = new Vector3(0, 200, 0);

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //JumpScript = cc.GetComponent<PLJump>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position =
            Vector3.SmoothDamp(transform.position, transform.position + var_vel, ref def_vec, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position =
            Vector3.SmoothDamp(transform.position, transform.position - var_vel, ref def_vec, speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position =
            Vector3.SmoothDamp(transform.position, transform.position - hol_vel, ref def_vec, speed * 2);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position =
            Vector3.SmoothDamp(transform.position, transform.position + hol_vel, ref def_vec, speed * 2);
        }

        //ジャンプ
        if (Input.GetKey(KeyCode.Space))
        {
            if (JumpScript.getJudge() == true)
            {
                //Debug.Log(JumpScript.getJudge());
                rb.AddForce(0, jump_power, 0);
                //PL.y += jump_power;
            //    transform.position =
            //Vector3.SmoothDamp(transform.position, transform.position + hig_vel, ref def_vec, jump_power);
            }
        }
        rb.AddForce(0, -6, 0);
    }
}
