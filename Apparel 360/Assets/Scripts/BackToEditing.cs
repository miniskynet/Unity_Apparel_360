using UnityEngine;

public class BackToEditing : MonoBehaviour
{
    public GameObject prevCanvas;
    public GameObject prevCam;
    public GameObject humanModel;
    public GameObject shirt;

    
    public void goBack()
    {
        //reverts the changes made when switching from customize menu to augmented reality 
        prevCanvas.SetActive(true);
        prevCam.SetActive(true);
        humanModel.SetActive(false);
        shirt.transform.position = new Vector3(11, 0, 1);
        shirt.transform.localScale = new Vector3(1, 1, 1);
    }
    
}
