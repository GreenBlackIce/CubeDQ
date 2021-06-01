using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public CharacterController controller; 
    public float speed = 12f;
    public float smoothingTime = 0.1f;
    private float smootingVel;

    void Start() 
    {
        gameObject.GetComponent<Animator>().enabled = false;    
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0.0f, vertical).normalized;


        if(direction.magnitude >= 0.01f)
        {
            gameObject.GetComponent<Animator>().enabled = true;
            float targetAngel = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngel, ref smootingVel, smoothingTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            controller.Move(direction * speed * Time.deltaTime);
        }
        else
        {
            gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
