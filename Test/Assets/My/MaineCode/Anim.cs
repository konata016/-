using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    public Rigidbody rb;
    private Animator anim;
    public AnimJump JumpScript;

    int Count = 1000;
    bool frg = false;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Running", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("Running", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Running", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
        }


        //ƒWƒƒƒ“ƒv
        if (Input.GetKey(KeyCode.Space))
        {
            if (JumpScript.getJudge())
            {
                anim.SetBool("Jump", true);
            }
        }

        if (!JumpScript.getJudge() && anim.GetBool("Jump"))
        {
            anim.SetBool("Jump", false);
            frg = true;
        }
        if (JumpScript.getJudge() && frg)
        {
           
                frg = false;
                anim.SetBool("Ground", true);
            
        }
        if (anim.GetBool("Ground") && Input.anyKeyDown)
        {
           anim.SetBool("Ground", false);
        }
       




        //if (JumpScript.getJudge() && anim.GetBool("Jump"))
        //{
        //    if (rb.velocity.y == 0f && anim.GetBool("Ground"))
        //    {
        //        anim.SetBool("Jump", false);
        //    }
        //    anim.SetBool("Ground", true);
        //}
        //else
        //{
        //    anim.SetBool("Ground", false);
        //}
    }
}
