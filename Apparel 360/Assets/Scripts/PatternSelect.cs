using UnityEngine;
public class PatternSelect : MonoBehaviour
{
    public GameObject shirt;
    public Material pattern;
    public void pickPattern()
    {
        //sets the shirt/Tshirt material as the one user selected
        shirt.GetComponent<Renderer>().material = pattern;
    }
}
