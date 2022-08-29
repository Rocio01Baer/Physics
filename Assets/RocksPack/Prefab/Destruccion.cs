using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour
{
   /* void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Roca")
        {
            Destroy(gameObject);
        }
    }*/
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entro en Colisión");
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("Esta en Colisión");
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Salio de Colisión");
    }
}
