using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {
    private bool isPlayerInside = false;
    public GameObject llave;
    private AudioSource sonido_Llaves;
  
    

    void Start () {
        llave.SetActive(true);
        sonido_Llaves = GetComponent<AudioSource>();
        
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerInside)
        {
            llave.SetActive(false);
            GameObject.Find("ElJugador").GetComponent<Inventario>().iKey += 1;
            
            if(llave.activeInHierarchy)
            {
			    sonido_Llaves.Stop();
		    }else
            {
			    sonido_Llaves.Play(); 	
		    }
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
