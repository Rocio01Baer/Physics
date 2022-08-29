using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruev : MonoBehaviour
{
    public GameObject Logo_UNIDAOriginal;
    //public float sec = 14f;
   
    /*float time;
    float timeDelay;*/
    // Start is called before the first frame update
    void Start()
    {
       // Invoke("wakeup", 240f);
        StartCoroutine(ActivationRoutine()); 
        /*time = 0f;
        timeDelay = 1f;*/

    }
    /*void wakeup()
    {
        gameObject.active = true;
    }*/
    
    private IEnumerator ActivationRoutine()
    {
        //Wait for 14 secs.
        yield return new WaitForSeconds(14);
        //  this.GetComponent<Name>.enabled = true;
        //Turn My game object that is set to false(off) to True(on).
        // Logo_UNIDAOriginal.SetActive(true);
        GameObject.Find("Roca").SetActive(true);

        //Turn the Game Oject back off after 1 sec.
        //yield return new WaitForSeconds(1);

        //Game object will turn off
        // Logo_UNIDAOriginal.SetActive(false);
    }
    /*
    // Update is called once per frame
    void Update()
    {
        Destroy(Logo_UNIDAOriginal, 2f);
      //  time = time + 1f * Time.deltaTime.Logo_;
        
       /* if (time >= timeDelay)
        {
            time = 0f;
            Logo_UNIDAOriginal.SetActive(true);
            //this.transform.position = this.transform.position + new Vector3(01, 1f, 0f);
        }
    }*/
}

