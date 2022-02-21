using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TogglePanel : MonoBehaviour {
	public GameObject Panel;

	public void clickEvent()
	{
		if(!Panel.activeSelf) {
			Panel.SetActive(true);
		}else{
			Panel.SetActive(false);
		}
	}
	
}
