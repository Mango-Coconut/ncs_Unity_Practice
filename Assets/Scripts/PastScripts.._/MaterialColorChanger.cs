using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorChanger : MonoBehaviour
{
    MeshRenderer rdr;

    void Start()
    {
        rdr = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            rdr.material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            rdr.material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            rdr.material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            rdr.material.color = Color.yellow;
        }
    }
}
