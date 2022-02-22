using UnityEngine;

public class Reset: MonoBehaviour
{
    public Camera camera;
    private static Vector3 cameraPosition;
    public void Start()
    {
        cameraPosition = camera.transform.position;
    }
    
    public void onClick()
    {
        camera.transform.position = cameraPosition;
        camera.transform.eulerAngles = new Vector3(0,180,0);
    }
}