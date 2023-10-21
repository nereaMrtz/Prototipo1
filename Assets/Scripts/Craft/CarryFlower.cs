using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class CarryFlower : MonoBehaviour
{
   
    Flower colorFlower;
    PJ_Movement aux;
    
    private void OnMouseDown()
    {
        if(gameObject.tag == "flower")
        {
            colorFlower = gameObject.GetComponent<Flower>();
            aux = FindAnyObjectByType<PJ_Movement>();
            Debug.Log("carry flor");
            aux.handFlower1.SetActive(true);
        }
    }
}
