using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour{

	public GameObject invetaryPanel;
	//public Sprite swordSprite;
	public GameObject backgroundPanel;

	public void addNewItem(Sprite sprite){

		GameObject item = new GameObject();
		item.transform.SetParent(invetaryPanel.transform);
		Image image = item.AddComponent<Image>();
		image.sprite = sprite;
	} 

	public void RemoveItem(){

	}

	private void Star(){

		backgroundPanel.SetActive(false);
	}

	private void Update(){
		if(Input.GetKeyDown(KeyCode.B)){
			backgroundPanel.SetActive(!backgroundPanel.activeSelf);
		}


	}
}