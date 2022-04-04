using UnityEngine;
using UnityEngine.UI;
public class CollarSelect : MonoBehaviour
{
    public GameObject shirtCollar;
    public GameObject clone;
    public GameObject model;
    public int collarCount;
    public Button clickedButton;
    public void spawnCollar()
    {
        if(collarCount==0)
        {
            //retrieve the position of the shirt/Tshirt and spawn the collar at the correct position and rotation in relation to that
            clickedButton.GetComponent<Image>().color = Color.gray;
            Vector3 modelLocation = model.transform.position;
            Material modelMaterial = model.GetComponent<Renderer>().material;
            Vector3 modelLocationFinal1 = new Vector3(modelLocation.x, modelLocation.y+0.28f, modelLocation.z);
            clone = Instantiate(shirtCollar, modelLocationFinal1, Quaternion.Euler(-90,0,0));
            //change the material according to the one user selected
            clone.GetComponent<Renderer>().material = modelMaterial;
            clone.SetActive(true);
            //set collar parent to shirt/Tshirt model
            clone.transform.parent = model.transform;
            collarCount++;
        }
        else
        {
            //revert button color to original
            clickedButton.GetComponent<Image>().color = Color.white;
            //destroy the collar object if user deselects button
            Destroy(clone);
            collarCount--;
        }
    }
}