using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAnima : MonoBehaviour {

    public float speed = 0.09f;

    public PLJump JumpScript;
    public float jump_power = 70f;
    
    public Rigidbody rb;

    private Animator anim;
    //private AnimatorStateInfo AnimatorStateInfo;

    Vector3
        def_vec = Vector3.zero,
        var_vel = new Vector3(0, 0, 1),
        hol_vel = new Vector3(1, 0, 0),
        hig_vel = new Vector3(0, 200, 0);

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        //AnimatorStateInfo = anim.GetCurrentAnimatorStateInfo(0);
        //JumpScript = cc.GetComponent<PLJump>();


    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Running", true);
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
            //transform.position =
            //Vector3.SmoothDamp(transform.position, transform.position - hol_vel, ref def_vec, speed * 2);
            transform.Rotate(0, 10, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position =
            //Vector3.SmoothDamp(transform.position, transform.position + hol_vel, ref def_vec, speed * 2);
            transform.Rotate(0, -10, 0);
        }

        //ジャンプ
        if (Input.GetKey(KeyCode.Space))
        {
            if (JumpScript.getJudge() == true)
            {
                rb.AddForce(0, jump_power, 0);   
            }
            
        }
        rb.AddForce(0, -2, 0);

        
    }
}
