using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors : MonoBehaviour {
	public int keys=0;
	private bool isPlayerInside = false;
	public GameObject puerta;

	// Use this for initialization
	void Start () {
		puerta.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E) && isPlayerInside)
        	{
           		 puerta.SetActive(false);
            
        	}
	}
	 private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("Se encontro jugador");
            isPlayerInside = true;
            
        }
        
    }
    	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player")) 
		{
			Debug.Log("Jugador salio");
			isPlayerInside = false;
		}
	}
}
