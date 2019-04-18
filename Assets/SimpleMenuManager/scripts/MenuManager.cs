using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

	public string initialMenu;

	public GameObject[] menus;

	private GameObject m_ActiveMenu;

	void Start() {
		Open(initialMenu);
	}

	public void Open(string name) {
		foreach(GameObject menu in menus) {
			if(menu.name == name) {
				menu.SetActive(true);
				m_ActiveMenu = menu;
			} else {
				menu.SetActive(false);
			}
		}
	}

	public void OpenFromLeft(string name)
	{
		foreach(GameObject menu in menus) {
			if(menu.name == name) {

				if (m_ActiveMenu != null)
					m_ActiveMenu.AddComponent<UITranslateAnimation>().AnimateOutLeft(1f);

				menu.AddComponent<UITranslateAnimation>().AnimateInLeft(1f);

				m_ActiveMenu = menu;
				return;
			}
		}
	}

	public void OpenFromRight(string name)
	{
		foreach(GameObject menu in menus) {
			if(menu.name == name) {

				if (m_ActiveMenu != null)
					m_ActiveMenu.AddComponent<UITranslateAnimation>().AnimateOutRight(1f);

				menu.AddComponent<UITranslateAnimation>().AnimateInRight(1f);
				
				m_ActiveMenu = menu;
				return;
			}
		}
	}
	
}
