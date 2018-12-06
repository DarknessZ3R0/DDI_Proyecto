using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour {
	 private bool isPlayerInside = false;
	 public GameObject AdudioA;
	 public GameObject AdudioB;
	 public GameObject AdudioC;
	 public GameObject AdudioD;
	 private int aleatorio=0;
	 
	void Start () {
		//AdudioA = GameObject.GetComponent<AudioSource>();
		//AdudioB = GameObject.GetComponent<AudioSource>();
		//AdudioC = GameObject.GetComponent<AudioSource>();
		//AdudioD = GameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		switch(aleatorio){
			case 1:	
						AdudioA.GetComponent<AudioSource>().Play();
					
						
					break;
			case 2: 
						AdudioB.GetComponent<AudioSource>().Play();
					
					break;
			case 3: 
						AdudioC.GetComponent<AudioSource>().Play();
						
					
					break;
			case 4: 
						AdudioD.GetComponent<AudioSource>().Play();
						
					break;

		}
		
	}
	private void OnTriggerEnter(Collider other)
    {
		
		
        if (other.CompareTag("Player"))
        {
			
			aleatorio = Random.Range(1,4);
			Debug.Log("Entro Numero: "+aleatorio);
            isPlayerInside = true;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
			Debug.Log("Salio");
            isPlayerInside = false;
		
        }
	}

	
}
