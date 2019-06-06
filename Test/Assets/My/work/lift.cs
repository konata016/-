using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift : MonoBehaviour
{

    //取得
    public PlaneUp s;
    Vector3 v3;

    Vector3 maxV3;
    Vector3 minV3;

    public float min = 0.0f;
    public float max = 0.0f;

    //public GameObject planet;   // 引力の発生する星
    public float coefficient;	// 万有引力係数

    public Rigidbody rb;

    private void Start()
    {
        v3 = s.Planet();

       rb = GetComponent<Rigidbody>();
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

        if (s.PlanetFrg() == true)
        {
            //力を与える
            rb.AddForce(new Vector3(gravity * direction.normalized.x, 0, 0), ForceMode.Force);
        }
    }
   
}