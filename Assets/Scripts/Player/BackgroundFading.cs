using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFading : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.tag == "Carraige")
        {
        GameObject.Find("PCamera").GetComponent<BackgroundChange>().inCarriage = true;
        GameObject.Find("FadeBackground").GetComponent<InsideBackground>().isFaded = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.transform.tag == "Carraige")
        {
        GameObject.Find("PCamera").GetComponent<BackgroundChange>().inCarriage = false;
        GameObject.Find("FadeBackground").GetComponent<InsideBackground>().isFaded = false;

        }
    }

}
