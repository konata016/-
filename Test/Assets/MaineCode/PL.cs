using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL : MonoBehaviour {

    public float speed = 300f;

    public PLJump JumpScript;
    public float jump_power = 100f;

    public Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
	float jamp_fg=JumpScript.getJudge() ?  1.0f : 0.5f;

        //Walk
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * jamp_fg ); //ê≥ñ 
        }

        //Direction of Caracter's face
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            transform.rotation = Quaternion.LookRotation(transform.position +
            (Vector3.right * Input.GetAxisRaw("Horizontal")) +
            (Vector3.forward * Input.GetAxisRaw("Vertical"))
            - transform.position);

        }


        //ÉWÉÉÉìÉv
        //if (Input.GetKey(KeyCode.Space) && Mathf.Abs(rb.velocity.y) == 0f)
        //{
        //    rb.AddForce(0, jump_power, 0);
        //}

        //èdóÕ
        //Physics.gravity = new Vector3(0, -20f, 0);


        if (Input.GetKey(KeyCode.Space))
        {
            if (JumpScript.getJudge() == true)
            {
                //rb.AddForce(0, jump_power * Time.deltaTime, 0);
                // velocity.y += jump_power;
                rb.AddForce(Vector3.up * jump_power);
            }
        }
        
        //else
        //{
        //    rb.AddForce(0, -5, 0);
        //}
    }
}
