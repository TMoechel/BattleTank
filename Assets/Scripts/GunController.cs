using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private float currentRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(transform.parent.position, Vector3.forward, currentRotation);
            //transform.rotation = Quaternion.Euler(Vector3.forward * currentRotation);
            currentRotation += 0.0001f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(transform.parent.position, Vector3.back, currentRotation);
            currentRotation += 0.0001f;
        }
        
    }
}
