using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorLlaves : MonoBehaviour {
	private int cLlaves = 0;
	
	public Text textollaves;
	
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

		cLlaves=GameObject.Find("ElJugador").GetComponent<Inventario>().iKey;
	
		textollaves.text = "Llaves: " + cLlaves;
	}
}
