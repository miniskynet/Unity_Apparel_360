using UnityEngine;
using UnityEngine.UI;
public class CuffSelect : MonoBehaviour
{
    public GameObject shirtCuff;
    public GameObject clone1;
    public GameObject clone2;
    public GameObject model;
    public int cuffCount;
    public static int count=0;
    public Button clickedButton;
    public void spawnCuff()
    {
        if(cuffCount==0)
        {
            //grey out the clicked button
            clickedButton.GetComponent<Image>().color = Color.gray;
            //retrieve the location of shirt/Tshirt and spawn two collars with changed rotation and position
            Vector3 modelLocation = model.transform.position;
            Material modelMaterial = model.GetComponent<Renderer>().material;
            Vector3 modelLocationFinal1 = new Vector3(modelLocation.x+0.62f, modelLocation.y-0.03f, modelLocation.z+0.03f);
            Vector3 modelLocationFinal2 = new Vector3(modelLocation.x-0.62f, modelLocation.y-0.03f, modelLocation.z+0.03f);
            clone1 = Instantiate(shirtCuff, modelLocationFinal1, Quaternion.Euler(28,90,-40));
            clone2 = Instantiate(shirtCuff, modelLocationFinal2, Quaternion.Euler(28,-90,-40));
            clone1.GetComponent<Renderer>().material = modelMaterial;
            clone2.GetComponent<Renderer>().material = modelMaterial;
            clone1.SetActive(true);
            clone2.SetActive(true);
            clone1.transform.parent = model.transform;
            clone2.transform.parent = model.transform;
            cuffCount++;
        }
        else
        {
            //revert button color to original
            clickedButton.GetComponent<Image>().color = Color.white;
            //destroy the cuff objects if user deselects button
            Destroy(clone1);
            Destroy(clone2);
            cuffCount--;
        }
    }
}