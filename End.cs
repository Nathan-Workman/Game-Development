using System.Collections;
using System.Collections.Generic;
using System.Runtime.Hosting;
using UnityEngine;

public class End : MonoBehaviour
{
    
    void OnTriggerEnter(Collider ProlougeEnd)
    {
        StartCoroutine(waitCoroutine());

        IEnumerator waitCoroutine()
        {
            yield return new WaitForSeconds(120);


            //if (other.tag == "End")
                
                Application.LoadLevel("Welcome");


        }

    }
}