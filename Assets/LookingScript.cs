using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingScript : MonoBehaviour
{

    public float mouseSens = 500;
    public Transform playerModel;
    private float rotationY;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float yAxis = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        rotationY -= yAxis;
        rotationY = Mathf.Clamp(rotationY,-90f,90f);

        playerModel.transform.Rotate(Vector3.up * xAxis);
        transform.localRotation = Quaternion.Euler(rotationY,0f,0f);
    }
}
