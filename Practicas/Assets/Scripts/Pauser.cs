using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class Pauser : MonoBehaviour {
	private bool paused = false;
	public GameObject pausePanel;
	public GameObject audio;

	public bool mute;

	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.P))
		{
			paused = !paused;
			pausePanel.SetActive(paused);
		}

		if(paused)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
	}

	public void ContinueGame(){

		Debug.Log("Continuar");
		paused = false;
		pausePanel.SetActive(paused);
	}
	public void ResetGame(){

		Debug.Log("ResetGame");
		SceneManager.LoadScene(0);

	}
	public void unMusicGame(){

		Debug.Log("unMusicGame");

		mute = !mute;
			audio.SetActive(mute);	
	
	}
}