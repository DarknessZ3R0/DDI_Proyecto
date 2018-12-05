﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors : MonoBehaviour {
	public int keys=0;
	private bool isPlayerInside = false;
	public GameObject puerta;
    private int numLlaves = 0;
	public GameObject panelLlaves;

    // Use this for initialization
    void Start () {
		puerta.SetActive(true);
		panelLlaves.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        numLlaves=GameObject.Find("ElJugador").GetComponent<Inventario>().iKey;
        if (Input.GetKeyDown(KeyCode.E) && isPlayerInside && numLlaves==keys)
        {
           		 puerta.SetActive(false);

        }
      
	}
	 private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;
			if(this.numLlaves != keys){
				panelLlaves.SetActive(true);   
			}
			
        }
        
    }
    	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player")) 
		{
			isPlayerInside = false;
			panelLlaves.SetActive(false);
		}
	}
}
