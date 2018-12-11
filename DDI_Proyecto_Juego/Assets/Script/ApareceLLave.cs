using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceLLave : MonoBehaviour {
	
	private int llavesInventario=0;
	public int llavesNesesarias=0;
	public GameObject llaveDorada;
	// Use this for initialization
	void Start () {
		llaveDorada.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		llavesInventario=GameObject.Find("ElJugador").GetComponent<Inventario>().iKey;
		if(llavesInventario==llavesNesesarias){
			llaveDorada.SetActive(true);
			if(GameObject.Find("ElJugador").GetComponent<Inventario>().MasterKey==1){
				llaveDorada.SetActive(false);
			}
		}
	}


}
