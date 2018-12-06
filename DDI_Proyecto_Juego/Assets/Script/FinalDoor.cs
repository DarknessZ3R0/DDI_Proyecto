using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour {
	public GameObject door;
	public GameObject panelLlaves;
	public int Master_Key_Required=1;
	private bool isPlayerInside = false;
    private int User_Keys = 0;
    void Start () {
		door.SetActive(true);
		panelLlaves.SetActive(false);
	}
	void Update () {
        User_Keys=GameObject.Find("ElJugador").GetComponent<Inventario>().MasterKey;
        if (Input.GetKeyDown(KeyCode.E) && isPlayerInside && User_Keys==Master_Key_Required)
        {
           		 door.SetActive(false);

        }
      
	}
	 private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;
			if(this.User_Keys != Master_Key_Required){
				panelLlaves.SetActive(true);   
			}
			
        }
        
    }
    	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player")) 
		{
			isPlayerInside = false;
			panelLlaves.SetActive(false);
		}
	}
}
