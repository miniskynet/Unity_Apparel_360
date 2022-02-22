using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        if (Input.GetKey("right"))
        { 
            transform.RotateAround(target.transform.position,Vector3.up, 50*Time.deltaTime); 
        }else if (Input.GetKey("left"))
        { 
            transform.RotateAround(target.transform.position,Vector3.down, 50*Time.deltaTime); 
        }else if (Input.GetKey("up"))
        { 
            transform.RotateAround(target.transform.position,Vector3.right, 50*Time.deltaTime); 
        }else if (Input.GetKey("down"))
        { 
            transform.RotateAround(target.transform.position,Vector3.left, 50*Time.deltaTime); 
        }
        
    }
    
}
