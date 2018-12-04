using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {
    private bool isPlayerInside = false;
    public GameObject llave;
    // Use this for initialization
    void Start () {
        llave.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerInside)
        {
            llave.SetActive(false);
            GameObject.Find("ElJugador").GetComponent<Inventario>().iKey += 1;
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
