using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeballThrower : MonoBehaviour {

	public GameObject pokeballPrefab;
	public float throwSpeed = 13f;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			transform.LookAt(Vector3.zero);
			GameObject pokeball = (GameObject) Instantiate(pokeballPrefab,transform.position,transform.rotation);

			pokeball.GetComponent<Rigidbody>().AddForce(transform.forward * throwSpeed, ForceMode.Impulse);
		}
		
	}
}
