using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InteractableArea))]
public class PickUpObject : MonoBehaviour 
{
	InteractableArea interactable;
	GameObject inventoryPanel;

	public Sprite sprite;

	void Start ()
	{
		interactable = GetComponent<InteractableArea> ();
		inventoryPanel = GameObject.FindGameObjectWithTag ("Inventory");
		//inventoryPanel = FindObjectOfType<Inventory>();
	}

	void Update () 
	{
		if (interactable.isInsideArea && Input.GetKeyDown (KeyCode.Y)) 
		{
			PickUp ();
			Destroy (gameObject);
		}
	}

	void PickUp()
	{
		GameObject item = new GameObject ();
		Image itemImage = item.AddComponent<Image> ();
		if (sprite != null) {
			itemImage.sprite = sprite;
		}
		item.name = gameObject.name + " item";
		item.transform.SetParent (inventoryPanel.transform);
	}
}
