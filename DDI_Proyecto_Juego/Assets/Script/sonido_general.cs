using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido_general : MonoBehaviour {
    private bool isplayerinside = false;
	private bool activo = true;
    private AudioSource sonido_g;
    

    void Start () {
        sonido_g = GetComponent<AudioSource>();//sonidos
        sonido_g.Stop();
	}
	
	void Update () {
            if(isplayerinside && activo == true)
            {   
                activo = false;
			    sonido_g.Play();
		    }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            
            isplayerinside = true;

        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            isplayerinside = false;
        }
    }
    

}




