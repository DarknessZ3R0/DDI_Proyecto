using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	
	private bool paused=false;
	public GameObject Panel;

	// Use this for initialization
	void Start () {
			Panel.SetActive(paused);

	}
	
	// Update is called once per frame
	void Update () {
		
//falta congelar la imagen 
		if (Input.GetKeyDown(KeyCode.P)){
			paused=!paused; 
			Panel.SetActive(paused);
		}
		if(paused)
			Time.timeScale=0;
		else 
			Time.timeScale=1;
		SceneManager.LoadScene(0);
		
		if (Input.GetKeyDown(KeyCode.R)){
			Debug.Log("si funciona wey");
			 Application.LoadLevel("Mapa_pricipal");
			 //quitar las llaves que tenias
		}
		
	}
	
}
