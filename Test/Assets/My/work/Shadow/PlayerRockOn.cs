using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRockOn : MonoBehaviour
{
    public GameObject pl;
    Quaternion rotation;

    void Update()
    {
            rotation = Quaternion.LookRotation(new Vector3(0, 0, 1), pl.transform.position - transform.position);
            transform.rotation = rotation;  
    }

    
}