using System;
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
        prevCanvas.SetActive(false);
        prevCam.SetActive(false);
        humanModel.SetActive(true);
        shirt.transform.position = new Vector3(0, -140, -83);
        shirt.transform.localScale = new Vector3(100, 100, 100);
    }

    private void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        WebCamTexture tex = new WebCamTexture(devices[0].name);
        background.material.mainTexture = tex;
        tex.Play();
    }
}