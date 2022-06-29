using System.Collections;
using System.Collections.Generic;
using System.Runtime.Hosting;
using UnityEngine;

public class TextScreen : MonoBehaviour
{

    void Start()
    
    {
        StartCoroutine(waitCoroutine());

        IEnumerator waitCoroutine()
        {
            yield return new WaitForSeconds(20);


            //if (other.tag == "End")

            Application.LoadLevel("Showcase");


        }

    }
}