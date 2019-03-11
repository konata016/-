using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HitShadow : MonoBehaviour {

    //接地した場合の処理
    public UnityEvent OnStayShadow;

    private void OnTriggerStay(Collider other)
    {
        OnStayShadow.Invoke();
    }
    private void OnTriggerExit(Collider collision)
    {
        OnStayShadow.Invoke();
    }
}
