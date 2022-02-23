using UnityEngine;

public class CameraMovement : MonoBehaviour
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
        }else if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            transform.Translate(Vector3.forward*0.3f);
        }else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            transform.Translate(Vector3.back*0.3f);
        }

    }
    
}
