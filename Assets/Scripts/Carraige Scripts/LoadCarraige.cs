using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCarraige : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player" && col.gameObject.GetComponent<MoveCharacter>().moveDirection == 1)
        {
            GameObject.Find("Game Manager").GetComponent<CarraigeLoading>().LoadNext();
        }    
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player" && col.gameObject.GetComponent<MoveCharacter>().moveDirection == -1)
        {
            GameObject.Find("Game Manager").GetComponent<CarraigeLoading>().LoadLast();
        }
    }

}
