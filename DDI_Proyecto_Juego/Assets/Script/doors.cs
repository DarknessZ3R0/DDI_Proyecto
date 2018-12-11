using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doors : MonoBehaviour {
	public int keys;
	private bool isPlayerInside = false;
	public GameObject puerta;
    private int llavesInventario = 0;
	public GameObject panelLlaves;
	public GameObject panelFaltantes;
	private int resultado;
	public Text faltantes;

	

    // Use this for initialization
    void Start () {
		puerta.SetActive(true);
		panelLlaves.SetActive(false);
		panelFaltantes.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
        llavesInventario=GameObject.Find("ElJugador").GetComponent<Inventario>().iKey;
		
        if (Input.GetKeyDown(KeyCode.E) && isPlayerInside && llavesInventario>=keys)
        {
           		 puerta.SetActive(false);
				
        }
      
	}
	 private void OnTriggerEnter(Collider other)
    {
		
        if (other.CompareTag("Player"))
        {
			
			resultado = keys - llavesInventario;
			faltantes.text= "Llaves necesarias: " + resultado;
            isPlayerInside = true;
			if(this.llavesInventario != keys){
				panelLlaves.SetActive(true);
				panelFaltantes.SetActive(true);   
			}
			
        }
        
    }
    	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player")) 
		{
			isPlayerInside = false;
			panelFaltantes.SetActive(false);
			panelLlaves.SetActive(false);
		}
	}
}
