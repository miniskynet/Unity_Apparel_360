using UnityEngine;
public class TogglePanel : MonoBehaviour {
	public GameObject Panel;
	public void clickEvent()
	{
		//clicking the button toggles the panel on or off
		if(!Panel.activeSelf) {
			Panel.SetActive(true);
		}else{
			Panel.SetActive(false);
		}
	}
}
