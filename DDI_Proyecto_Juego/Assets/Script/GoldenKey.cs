﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenKey : MonoBehaviour {

    private bool isPlayerInside = false;
    public GameObject llaveDorada;
    void Start () {
        llaveDorada.SetActive(false);
	}
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerInside)
        {
            llaveDorada.SetActive(false);
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
