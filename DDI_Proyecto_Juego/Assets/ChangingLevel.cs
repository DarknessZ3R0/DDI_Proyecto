using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingLevel : MonoBehaviour
{
    public bool enter = true;

    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            Debug.Log("entered");
        }
    }

}
