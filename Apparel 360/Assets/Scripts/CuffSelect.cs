using System.Collections.Generic;
using UnityEngine;

public class CuffSelect : MonoBehaviour
{
    public GameObject shirtCuff;
    public GameObject clone1;
    public GameObject clone2;
    public GameObject model;
    public int cuffCount;
    public static int count=0;


    public void spawnCuff()
    {
        if(cuffCount==0)
        {
            Vector3 modelLocation = model.transform.position;
            Vector3 modelLocationFinal1 = new Vector3(modelLocation.x+0.62f, modelLocation.y-0.05f, modelLocation.z+0.07f);
            Vector3 modelLocationFinal2 = new Vector3(modelLocation.x-0.62f, modelLocation.y-0.02f, modelLocation.z+0.07f);
            clone1 = Instantiate(shirtCuff, modelLocationFinal1, Quaternion.Euler(0,0,60));
            clone2 = Instantiate(shirtCuff, modelLocationFinal2, Quaternion.Euler(0,0,-60));
            clone1.SetActive(true);
            clone2.SetActive(true);
            clone1.transform.parent = model.transform;
            clone2.transform.parent = model.transform;
            cuffCount++;
        }
        else
        {
            Destroy(clone1);
            Destroy(clone2);
            cuffCount--;
        }

    }
}