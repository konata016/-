using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public GameObject TargetPos;
    Vector3 V3;

    // Start is called before the first frame update
    void Start()
    {
       V3= transform.position - TargetPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = TargetPos.transform.position + V3;
    }
}
