using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour
{
    public GameObject shirt;
    public Color shirtColor;

    public void pickColor()
    {
        shirt.GetComponent<Renderer>().material.color = shirtColor;
    }
}
