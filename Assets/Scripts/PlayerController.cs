using UnityEngine;

[RequireComponent(typeof(PlayerMovment))]
public class PlayerController : MonoBehaviour
{

    public LayerMask movMask;
    Camera cam;
    PlayerMovment movment;

    private void Start() 
    {
        cam = Camera.main;
        movment = GetComponent<PlayerMovment>();
    }

    private void Update() 
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 300, movMask))
            {
                movment.MoveToPoint(hit.point);
            }
        }    


        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 300, movMask))
            {
                //Interactable
            }
        }    
    }
}
