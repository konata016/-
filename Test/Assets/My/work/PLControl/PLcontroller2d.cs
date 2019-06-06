using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PLcontroller2d : MonoBehaviour
{



    public float speed = 3f;

    public float JumpPower;             //ジャンプ力
    //接地判定
    public bool OnGround { get; set; }  //追記

    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Walk
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed ); //正面
        }

        //Direction of Caracter's face
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            transform.rotation = Quaternion.LookRotation(transform.position +
            (Vector3.right * Input.GetAxisRaw("Horizontal")) +
            (Vector3.forward * Input.GetAxisRaw("Vertical"))
            - transform.position);

        }

        //接地していればジャンプできる
        if (Input.GetButtonDown("Jump"))//追記
        {
            if (OnGround)
            {
                rb.velocity = transform.up * JumpPower;
                //ジャンプした瞬間接地判定を解除
                OnGround = false;//追記
            }
        }
        

    }
}
