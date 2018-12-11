using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenKey : MonoBehaviour {

    private bool isPlayerInside = false;
    
    private bool llavetomada=false;
    void Start () {
        
	}
	void Update () {

        if (Input.GetKeyDown(KeyCode.E) && isPlayerInside)
        {         
            GameObject.Find("ElJugador").GetComponent<Inventario>().MasterKey += 1;
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
