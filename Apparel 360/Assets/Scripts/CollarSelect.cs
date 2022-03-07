using System.Collections.Generic;
using UnityEngine;
public class CollarSelect : MonoBehaviour
{
    public GameObject shirtCollar;
    public GameObject clone;
    public GameObject model;
    public int collarCount;

    public void spawnCollar()
    {
        if(collarCount==0)
        {
            Vector3 modelLocation = model.transform.position;
            Vector3 modelLocationFinal1 = new Vector3(modelLocation.x, modelLocation.y+0.28f, modelLocation.z);
            clone = Instantiate(shirtCollar, modelLocationFinal1, Quaternion.Euler(-90,0,0));
            clone.SetActive(true);
            clone.transform.parent = model.transform;
            collarCount++;
        }
        else
        {
            Destroy(clone);
            collarCount--;
        }

    }
}