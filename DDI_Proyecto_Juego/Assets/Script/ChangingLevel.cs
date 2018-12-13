using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingLevel : MonoBehaviour
{
    private bool isPlayerInside = false;
    public string nivel;
void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
		
        if (Input.GetKeyDown(KeyCode.E) && isPlayerInside)
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
