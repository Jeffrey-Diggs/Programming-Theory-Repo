using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovements : MonoBehaviour
{
    private float movementSpeed = 60.0f;
    private float rotateSpeed = 2.0f;
    private GameObject cameraObj;
    void Start()
    {
        cameraObj = this.gameObject;
    }

    void Update()
    {
        CameraMoves(); // ABSTRACTION
        KeepCameraInBoundaries(); // ABSTRACTION

    }

    public void KeepCameraInBoundaries()
    {
        if (transform.position.y < 1.5f)
            transform.position = new Vector3(transform.position.x, 1.5f, transform.position.z);
        if (transform.position.y > 78.0f)
            transform.position = new Vector3(transform.position.x, 78.0f, transform.position.z);

        if (transform.position.x < -50.0f)
            transform.position = new Vector3(-50.0f, transform.position.y, transform.position.z);
        else if (transform.position.x > 63.0f)
            transform.position = new Vector3(63.0f, transform.position.y, transform.position.z);

        if (transform.position.z < -100.0f)
            transform.position = new Vector3(transform.position.x, transform.position.y, -100.0f);
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
            RotateCamera();
        }
    }

    void RotateCamera()
    {
        cameraObj.transform.Rotate(cameraObj.transform.up, Input.GetAxis("Mouse X") * rotateSpeed);
        cameraObj.transform.Rotate(cameraObj.transform.right, -Input.GetAxis("Mouse Y") * rotateSpeed);
    }
}
