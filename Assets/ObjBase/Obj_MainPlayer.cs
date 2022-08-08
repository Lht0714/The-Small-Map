using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_MainPlayer : Obj
{
    void Start()
    {

    }

    public void Update()
    {
        if (Go == null)
        {
            return;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Go.transform.position += Go.transform.forward * 5 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Go.transform.position += Go.transform.forward * 5 * -Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Go.transform.Rotate(Vector3.up * 40 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Go.transform.Rotate(Vector3.up * -40 * Time.deltaTime);
        }
    }
}
