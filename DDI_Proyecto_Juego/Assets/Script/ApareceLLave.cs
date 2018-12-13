using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceLLave : MonoBehaviour {
	
	private int llavesInventario=0;
	public int llavesNesesarias=0;
	public int llaveDoradaO=0;
	private bool isPlayerInside = false;
	public GameObject llaveDorada;
	public bool activador=false;
	private AudioSource sonido_Llaves;
	// Use this for initialization
	void Start () {
		llaveDorada.SetActive(false);
		 sonido_Llaves = GetComponent<AudioSource>();//sonidos
        sonido_Llaves.Stop();
	}
	
	// Update is called once per frame
	void Update () {
		llavesInventario=GameObject.Find("ElJugador").GetComponent<Inventario>().iKey;
		if(llavesInventario==llavesNesesarias && llaveDoradaO == 0){
			llaveDorada.SetActive(true);
			activador=true;			
		}else{
			llaveDorada.SetActive(false);
			activador=false;
		}
		 if (Input.GetButtonDown("InteractuarX") && isPlayerInside && activador==true)
        {
            llaveDorada.SetActive(false);
            GameObject.Find("ElJugador").GetComponent<Inventario>().MasterKey += 1;
			llaveDoradaO=GameObject.Find("ElJugador").GetComponent<Inventario>().MasterKey;
			sonido_Llaves.Play(); 	
		    
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
