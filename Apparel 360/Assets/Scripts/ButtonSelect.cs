using System.Collections.Generic;
using UnityEngine;

public class ButtonSelect : MonoBehaviour
{
    public GameObject shirtButton;
    public GameObject model;
    public int buttonCount;
    public GameObject clone;
    public GameObject[] buttonCollection = new GameObject[8];

    public void spawnButton()
    {

        if(buttonCount==0)
        {
            Vector3 modelLocation = model.transform.position;
            Vector3 modelLocationFinal = new Vector3(modelLocation.x, modelLocation.y+0.2f, modelLocation.z+0.13f);
            clone = Instantiate(shirtButton, modelLocationFinal, Quaternion.Euler(-30,0,0));
            clone.SetActive(true);
            clone.transform.parent = model.transform;
            buttonCollection[0] = clone;

            modelLocationFinal.z += 0.035f;
            for (int i = 0; i < 7; i++)
            {
                modelLocationFinal.y-=0.06f;
                clone = Instantiate(shirtButton, modelLocationFinal, Quaternion.Euler(0,0,0));
                clone.SetActive(true);
                clone.transform.parent = model.transform;
                buttonCollection[i+1] = clone;
            }

            buttonCount++;

    }
        else
        {
            foreach (GameObject button in buttonCollection)
            {
                Destroy(button);
            }

            buttonCount--;

        }

    }
}

