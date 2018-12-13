using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {
private bool isPlayerInside = false;
public string nivel;
	// Use this for initialization
void Update () {
        
		
        if ( isPlayerInside)
        {
           	LoadMapa();	 

        }
		
		
      
	}

	 private void LoadMapa()
    {
        Application.LoadLevel(nivel);
    }
	
	
    
	 private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {		
            isPlayerInside = true;
        }
        
    }
    private	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player")) 
		{
			isPlayerInside = false;
			
		}
	}
}
