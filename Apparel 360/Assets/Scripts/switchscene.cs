using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscene : MonoBehaviour
{
    public void switchsc() {
    if (SceneManager.GetActiveScene().name == "ShirtCustomizePage")
    {
        SceneManager.LoadScene("TshirtCustomizePage");
        SceneManager.UnloadScene("ShirtCustomizePage");
    }
    else if (SceneManager.GetActiveScene().name == "TshirtCustomizePage")
    {
        SceneManager.LoadScene("ShirtCustomizePage");
        SceneManager.UnloadScene("TshirtCustomizePage");
    }
    
}


}
