using UnityEngine;

public class ButtonSelect : MonoBehaviour
{
    public GameObject shirtButton;
    public GameObject clone;
    public GameObject model;
    public int buttonCount;

    public void spawnButton()
    {
        if(buttonCount==0)
        {
            Vector3 modelLocation = model.transform.position;
            Vector3 modelLocationFinal = new Vector3(modelLocation.x, modelLocation.y+0.2f, modelLocation.z+0.125f);
            clone = Instantiate(shirtButton, modelLocationFinal, Quaternion.Euler(-90,0,0));
            clone.transform.localScale = new Vector3(0.005f,0.005f,0.005f);
            clone.SetActive(true);
            clone.transform.parent = model.transform;//make the button a child of model so that rotate function works properly
            buttonCount++;
    }
        else
        {
            Destroy(clone);
            buttonCount--;
        }

    }
}

