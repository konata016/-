using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("false:瞬間移動　true:強い移動")]
    public bool ModeChange;
    public float Speed = 10f;
    Vector3 Pos;
    Rigidbody Rb;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!ModeChange)
        {
            //瞬間移動
            Pos = transform.position;
            if (Input.GetKey(KeyCode.W))
            {
                Pos.z += Speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                Pos.z -= Speed * Time.deltaTime;
            }
            transform.position = Pos;
        }
        else
        {
            //強い移動
            if (Input.GetKey(KeyCode.W))
            {
                Rb.AddForce(new Vector3(0, 0, Speed));
            }
        }
    }
}
