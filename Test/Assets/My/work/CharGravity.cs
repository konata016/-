using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharGravity : MonoBehaviour {

    //取得
    public PlaneUp s;
    Vector3 v3;

    //public GameObject planet;   // 引力の発生する星
    public float coefficient;	// 万有引力係数

    public Rigidbody rb;

    private void Start()
    {
        v3 = s.Planet();
    }

    private void Update()
    {
        v3 = s.Planet();
    }

    //アップデートより遅い
    void FixedUpdate()
    {
        // 星に向かう向きの取得
        var direction = v3 - transform.position;
        // 星までの距離の２乗を取得
        var distance = direction.magnitude;
        distance *= distance;
        // 万有引力計算
        var gravity = coefficient * rb.mass * 2 / distance;

        if (Input.GetMouseButton(1) && s.PlanetFrg() == true)
        {
            // 力を与える
            rb.AddForce(gravity * direction.normalized, ForceMode.Force);
        }
    }
}