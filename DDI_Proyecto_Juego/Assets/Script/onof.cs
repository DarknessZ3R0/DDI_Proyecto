using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onof : MonoBehaviour {
	public GameObject lampara;
	private bool on=true;

	// Use this for initialization
	void Start () {
		lampara.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("LamparaY"))
        	{	
        		if(on==true){
           		     lampara.SetActive(false);
           		     on=false;
        		}else{
        			lampara.SetActive(true);
        			on=true;
        		}
            
        	}
	}


	/*private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("Se encontro jugador");
            isPlayerInside = true;
            
        }
    }
   /*   	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player")) 
		{
			Debug.Log("Jugador salio");
			isPlayerInside = false;
		}
	}*/
}

