using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {
    private bool isPlayerInside = false;
    public GameObject llave;
    private AudioSource sonido_Llaves;
    private bool activa=true;
  
    

    void Start () {
        llave.SetActive(true);
        sonido_Llaves = GetComponent<AudioSource>();//sonidos
        sonido_Llaves.Stop();
        
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerInside && activa==true)
        {
            llave.SetActive(false);
            GameObject.Find("ElJugador").GetComponent<Inventario>().iKey += 1;
            
			sonido_Llaves.Play(); 	
		    activa=false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            
            isPlayerInside = true;

        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
            isPlayerInside = false;
        }
    }
}
