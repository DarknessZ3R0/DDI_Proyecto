using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorLlaveMaestra : MonoBehaviour {
	private int mLLave =0;
	public Text textollaves;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mLLave =GameObject.Find("ElJugador").GetComponent<Inventario>().MasterKey;
		textollaves.text = "Llave Maestra: " + mLLave ;
	}
}
