using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnMouseDown()
    {
        rb.AddForce(transform.up * 100);
        rb.useGravity = true;
    }
}
