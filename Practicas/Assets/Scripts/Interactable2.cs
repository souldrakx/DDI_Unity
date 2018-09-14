using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable2 : MonoBehaviour 
{
    public Color color;
    public GameObject infoPanel;
    private bool isPlayerInside = false;
    public float rotationSpeed = 3f;

    private void Start()
    {
        infoPanel.SetActive(false);
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);

        if(Input.GetKeyDown(KeyCode.E) && isPlayerInside)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            infoPanel.SetActive(true);
            isPlayerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoPanel.SetActive(false);
            isPlayerInside = false;
        }
    }
}
