using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenKey : MonoBehaviour {

    private bool isPlayerInside = false;
    private bool activa = false;
    
    private bool llavetomada=false;
    
    void Start () {
        
	}
	void Update () {
        
        if (Input.GetButtonDown("InteractuarX") && isPlayerInside && GameObject.Find("Master_key").GetComponent<ApareceLLave>().activador == true)
        {   
            GameObject.Find("ElJugador").GetComponent<Inventario>().MasterKey += 1;
            activa = false;
        }
    }
    
}
