using UnityEngine;
public class Reset: MonoBehaviour
{
    public Camera camera;
    private static Vector3 cameraPosition;
    public void Start()
    {
        //retrieve the position of the camera
        cameraPosition = camera.transform.position;
    }
    public void onClick()
    {
        //reverts the position of the camera on click 
        camera.transform.position = cameraPosition;
        camera.transform.eulerAngles = new Vector3(0,180,0);
    }
}