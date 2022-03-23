using System.Collections.Generic;
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
            clickedButton.GetComponent<Image>().color = Color.gray;
            Vector3 modelLocation = model.transform.position;
            Material modelMaterial = model.GetComponent<Renderer>().material;
            Vector3 modelLocationFinal1 = new Vector3(modelLocation.x, modelLocation.y+0.28f, modelLocation.z);
            clone = Instantiate(shirtCollar, modelLocationFinal1, Quaternion.Euler(-90,0,0));
            clone.GetComponent<Renderer>().material = modelMaterial;
            clone.SetActive(true);
            clone.transform.parent = model.transform;
            collarCount++;
        }
        else
        {
            clickedButton.GetComponent<Image>().color = Color.white;
            Destroy(clone);
            collarCount--;
        }

    }
}