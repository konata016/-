using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLcontroller : MonoBehaviour
{

    public float speed = 5f;            //移動速度
    public float rotateSpeed = 3.0f;    //回転速度

    public float JumpPower;             //ジャンプ力
    //接地判定
    public bool OnGround { get; set; }//追記

    Vector3 pos;


    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        OnGround = false;
    }


    void FixedUpdate()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(0, 0, v);

        // キャラクターのローカル空間での方向に変換
        velocity = transform.TransformDirection(velocity);

        // キャラクターの移動
        transform.localPosition += velocity * speed * Time.fixedDeltaTime;

        // キャラクターの回転
        transform.Rotate(0, h * rotateSpeed, 0);


        //接地していればジャンプできる
        if (Input.GetButtonDown("Jump") && OnGround)//追記
        {
            rb.velocity = transform.up * JumpPower;
            //ジャンプした瞬間接地判定を解除
            OnGround = false;//追記
        }

        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical") || OnGround == false)
        {
            Debug.Log("0000000");
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
        else
        {
            Debug.Log("aaaaaaaa");
            // 回転、位置ともに固定
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}