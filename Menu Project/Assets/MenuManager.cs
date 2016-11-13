using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
	public Menu CurrentMenu;

	// Use this for initialization
	public void Start () {
		ShowMenu (CurrentMenu);
	}
	
	// Update is called once per frame
	public void ShowMenu (Menu menu) {
		if (CurrentMenu != null) {
			CurrentMenu.IsOpen = false;
		} 
		CurrentMenu = menu;
		CurrentMenu.IsOpen = true;
	
	}
}
