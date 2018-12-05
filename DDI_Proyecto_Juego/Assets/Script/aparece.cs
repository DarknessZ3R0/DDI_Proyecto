using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparece : MonoBehaviour {
	public GameObject ObjetoB;
	public GameObject objetoA;

	void Start () {
		ObjetoB.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if(objetoA.activeInHierarchy){
			ObjetoB.SetActive(false);
		}else{
			ObjetoB.SetActive(true); 	
		}
	}
}
