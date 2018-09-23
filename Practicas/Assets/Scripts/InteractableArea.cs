using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class InteractableArea : MonoBehaviour 
{
	public GameObject infoCanvas;
	public Text panelText;
	public float explosionForce = 50f;
	public float explosionRadius = 30f;
	public Vector3 positionOffset;
	public bool isInsideArea = false;

	Rigidbody rigidBody;

	void Start()
	{
		infoCanvas.SetActive (false);
		rigidBody = GetComponent<Rigidbody> ();
	}

	void Update()
	{
		if (isInsideArea && Input.GetButtonDown("interact"))
		{
			HitChair ();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player")) 
		{
			infoCanvas.SetActive (true);
			isInsideArea = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player")) 
		{
			infoCanvas.SetActive (false);
			isInsideArea = false;
		}
	}

	public void ChangeText()
	{
		//Debug.Log ("Si jala!");
		panelText.text = "Bien hecho!";
	}

	public void HitChair()
	{
		Debug.Log ("item colectado!");
		//rigidBody.AddExplosionForce (explosionForce, transform.position + positionOffset, explosionRadius);
		Destroy(this.gameObject);
	}

	public void ExplodeAll()
	{
		InteractableArea[] chairs = FindObjectsOfType<InteractableArea> ();
		for (int i = 0; i < chairs.Length; i++) 
		{
			chairs [i].HitChair ();
		}
	}
}
