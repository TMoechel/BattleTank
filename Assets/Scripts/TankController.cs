using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    private float currentRotation = 0;
    void Start()
    {
        //transform.eulerAngles = Vector3.forward * 90;
    }

    // Update is called once per frame
    void Update()
    {
        var moveSpeed = 0.001f;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * currentRotation);
            currentRotation += 0.1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * currentRotation);
            currentRotation -= 0.1f;
        }
    }
}
