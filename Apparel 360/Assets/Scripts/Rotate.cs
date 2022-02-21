using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Camera camera;
    public GameObject target;
    void Update()
    {
        if (Input.GetKey("right"))
        { 
            transform.RotateAround(target.transform.position,Vector3.up, 20*Time.deltaTime); 
        }
        else if (Input.GetKey("left"))
        { 
            transform.RotateAround(target.transform.position,Vector3.down, 20*Time.deltaTime); 
        }
        
        Vector3 rotation = new Vector3(Input.GetAxisRaw("Mouse Y"), Input.GetAxisRaw("Mouse X"));
        if (Input.GetMouseButton(0))
        {
            camera.transform.RotateAround(camera.transform.position,rotation,20*Time.deltaTime); 
        }

        
    }
    
}
