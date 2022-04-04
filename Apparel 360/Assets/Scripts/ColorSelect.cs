using UnityEngine;
public class ColorSelect : MonoBehaviour
{
    public GameObject shirt;
    public Color shirtColor;
    public void pickColor()
    {
        //change color of shirt/Tshirt 
        shirt.GetComponent<Renderer>().material.color = shirtColor;
    }
}
