using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido_general : MonoBehaviour {

	 public GameObject objeto;
    private AudioSource sonido_g;
    

    void Start () {
       sonido_g = GetComponent<AudioSource>();//sonidos
        
	}
	
	void Update () {
            if(objeto.activeInHierarchy)
            {
			    sonido_g.Stop();
		    }else
            {
			    sonido_g.Play(); 	
		    }
        
    }

}




