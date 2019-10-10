using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboVerde : MonoBehaviour
{
    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnMouseDown()
    {
        transform.Translate(Vector3.forward, Space.Self);
        transform.Translate(Vector3.forward, Space.World);

        transform.localScale = new Vector3(2, 2, 2);

        Vector3 v = new Vector3(1, 1, 0);
        transform.position = v;

        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            print("Fire 1");
            transform.Translate(Vector3.forward * Time.deltaTime * 10);
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        print(x + ":" + z);

        float xMouse = Input.GetAxis("Mouse X");
        print(xMouse);
        //transform.Translate(Vector3.right * Time.deltaTime * xMouse);
    }
}
