using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternSelect : MonoBehaviour
{
    public GameObject shirt;
    public Material pattern;
        
    public void pickPattern()
    {
        shirt.GetComponent<Renderer>().material = pattern;
    }
}
