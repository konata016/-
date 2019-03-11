using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
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
        //動き
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
        //回転
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.LookRotation(transform.position +
                (new Vector3(1, 0, 0) * Input.GetAxisRaw("Horizontal")) -
                transform.position);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.LookRotation(transform.position +
                (new Vector3(1, 0, 0) * Input.GetAxisRaw("Horizontal")) -
                transform.position);
        }

        //変更
        if (rb.useGravity == true)
        {

            //接地していればジャンプできる
            if (Input.GetButtonDown("Jump") || Input.GetKey(KeyCode.W))//追記
            {
                if (OnGround)
                {
                    rb.velocity = transform.up * JumpPower;
                    //ジャンプした瞬間接地判定を解除
                    OnGround = false;//追記
                }
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
            }
        }


    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Shadow")
        {
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Shadow")
        {
            rb.useGravity = true;
        }
    }
}