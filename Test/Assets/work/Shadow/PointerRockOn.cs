using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerRockOn : MonoBehaviour {

    void Update()
    {

        var pos = Camera.main.WorldToScreenPoint(transform.position);
        var rotation = Quaternion.LookRotation(Vector3.forward, Input.mousePosition - pos);
        transform.localRotation = rotation;

    }
}
