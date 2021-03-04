using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarraigeLoading : MonoBehaviour
{
    public int CarraigeNum;
    public GameObject[] Carraiges;
    // Start is called before the first frame update
    void Start()
    {
        Carraiges[CarraigeNum].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(CarraigeNum == 3 || CarraigeNum == 5)
        {
            for (int i = 0; i < CarraigeNum - 2; i++)
            {
                Carraiges[i].SetActive(false);
            }
        }
    }
    public void LoadNext()
    {
        CarraigeNum = CarraigeNum + 1;
        Debug.Log(CarraigeNum);
        Carraiges[CarraigeNum].SetActive(true);
        Carraiges[CarraigeNum - 1].SetActive(true); 
    }
    public void LoadLast()
    {
        CarraigeNum = CarraigeNum - 1; 
        if(CarraigeNum < 1)
        {
            CarraigeNum = 1;
        }
        Debug.Log(CarraigeNum);
        Carraiges[CarraigeNum - 1].SetActive(true);
    }
}
