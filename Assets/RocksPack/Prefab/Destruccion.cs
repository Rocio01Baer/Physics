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
        Debug.Log("Entro en Colisi�n");
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("Esta en Colisi�n");
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Salio de Colisi�n");
    }
}
