using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour {
	 private bool playerinsisde=false;
	 public GameObject AdudioA;
	 public GameObject AdudioB;
	 public GameObject AdudioC;
	 public GameObject AdudioD;
	 private int aleatorio=0;
	 
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		

		}
		
	
	private void OnTriggerEnter(Collider other)
    {
		
		
        if (other.CompareTag("Player"))
        {
			
			aleatorio = Random.Range(1,4);
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

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
			AdudioA.GetComponent<AudioSource>().Stop();
			AdudioB.GetComponent<AudioSource>().Stop();
			AdudioD.GetComponent<AudioSource>().Stop();
           
		
        }
	}

}	

