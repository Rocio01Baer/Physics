using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Rock;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Entro Trigger");
    }
    void OnTriggerStay(Collider collider)
    {
        Rock.GetComponent<Rigidbody>().isKinematic = false;
        Debug.Log("Esta Trigger");
    }
    void OnTriggerExit(Collider collider)
    {
        Debug.Log("Salio Trigger");
    }

}
