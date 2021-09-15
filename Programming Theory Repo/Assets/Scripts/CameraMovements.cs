using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovements : MonoBehaviour
{
    public float movementSpeed = 20.0f;
    void Start()
    {
        
    }

    void Update()
    {
        CameraMoves();
        KeepCameraInBoundaries();
        
    }

    public void KeepCameraInBoundaries()
    {
        if (transform.position.y < 1.5f)
            transform.position = new Vector3(transform.position.x, 1.5f, transform.position.z);

        if (transform.position.x < -50.0f)
            transform.position = new Vector3(-50.0f, transform.position.y, transform.position.z);
        else if (transform.position.x > 63.0f)
            transform.position = new Vector3(63.0f, transform.position.y, transform.position.z);

        if (transform.position.z < -110.0f)
            transform.position = new Vector3(transform.position.x, transform.position.y, -110.0f);
        else if (transform.position.z > 33.0f)
            transform.position = new Vector3(transform.position.x, transform.position.y, 33.0f);
    }

    public void CameraMoves()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(-Vector3.forward * movementSpeed * Time.deltaTime);
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButton(1))
        {
            //TODO
        }
    }
}
