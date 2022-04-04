using UnityEngine;
using UnityEngine.UI;

public class ARswitch : MonoBehaviour
{
    public GameObject prevCanvas;
    public GameObject prevCam;
    public GameObject humanModel;
    public GameObject shirt;
    public Image background;
    
    public void loadAR()
    {
        //disables the original canvas and activates canvas with the augmented reality texture background
        prevCanvas.SetActive(false);
        prevCam.SetActive(false);
        //activates the human model and properly aligns the model
        humanModel.SetActive(true);
        shirt.transform.position = new Vector3(0, -140, -83);
        shirt.transform.localScale = new Vector3(100, 100, 100);
    }

    private void Start()
    {
        //upon starting the method,takes the user webcam input and sets it as texture of the canvas
        WebCamDevice[] devices = WebCamTexture.devices;
        WebCamTexture tex = new WebCamTexture(devices[0].name);
        background.material.mainTexture = tex;
        tex.Play();
    }
}