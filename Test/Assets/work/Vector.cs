using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    //自分の位置
    public Transform startPosition;


    float step = 0;
    //向くスピード(秒速)
    float speed = 0.01f;

    //取得
    public PlaneUp s;
    Vector3 v3;


    void Start()
    {

        startPosition = transform;
        v3 = s.Planet();
    }



    // Update is called once per frame
    void Update()
    {

        v3 = s.Planet();

        if (s.PlanetFrg() == true)
        {
            //秒速に直す計算
            step += speed * Time.deltaTime;
            //向き始めと終わりの点を計算して、stepの値より、今向くべき方向を算出
            transform.rotation = Quaternion.Slerp(startPosition.rotation, Quaternion.LookRotation((v3 - startPosition.position).normalized), step);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(startPosition.rotation,startPosition.rotation, step);
        }
    }
}