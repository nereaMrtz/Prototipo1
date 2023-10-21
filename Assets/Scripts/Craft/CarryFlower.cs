using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class CarryFlower : MonoBehaviour
{
   
    Flower colorFlower;
    PJ_Movement aux;

    private void Start()
    {
        colorFlower = gameObject.GetComponent<Flower>();
        aux = FindAnyObjectByType<PJ_Movement>();
    }

    private void OnMouseDown()
    {
        if(gameObject.tag == "flower")
        {
            if(colorFlower.GetColor() == Index.PURPLE) {
                Debug.Log("flor lila");
                aux.handFlower1.SetActive(true);
            }

            if(colorFlower.GetColor() == Index.BLUE) {
                Debug.Log("flor BLU");
                aux.handFlower4.SetActive(true);
            }
      
            
        }
    }
}
