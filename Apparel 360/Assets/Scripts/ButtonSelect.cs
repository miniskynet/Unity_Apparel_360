using System.Collections.Generic;
using UnityEngine;

public class ButtonSelect : MonoBehaviour
{
    public GameObject shirtButton;
    public GameObject clone;
    public GameObject model;
    public int buttonCount;
    private static List<GameObject> buttonList = new List<GameObject>();
    public static int count=0;

    void getChildren()
    {
        
        for (int i = 0; i < model.transform.childCount; i++)
        {
            buttonList.Add(model.transform.GetChild(i).gameObject);
        }
        count++;
    }

    public void spawnButton()
    {
        if(buttonCount==0)
        {
            Vector3 modelLocation = model.transform.position;
            Vector3 modelLocationFinal = new Vector3(modelLocation.x, modelLocation.y+0.2f, modelLocation.z+0.13f);
            clone = Instantiate(shirtButton, modelLocationFinal, Quaternion.Euler(-30,0,0));
            clone.SetActive(true);
            clone.transform.parent = model.transform;//make the button a child of model
            buttonCount++;
            getChildren();
            foreach (GameObject VARIABLE in buttonList)
            {
                Debug.Log("From :" + count + " " + VARIABLE);
            }
    }
        else
        {
            Destroy(clone);
            buttonList.Remove(clone);
            buttonCount--;
            getChildren();
            foreach (GameObject VARIABLE in buttonList)
            {
                Debug.Log("From :" + count + " " + VARIABLE);
            }
        }

    }
}

