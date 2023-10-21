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
            if(colorFlower.GetColor() == Index.PURPLE && aux.GetInventory().purpleCounter > 0) {
                Debug.Log("flor lila");
                aux.handFlower1.SetActive(true);
                aux.GetInventory().SubstractFlowerToInventory(Index.PURPLE);
            }
            else
            {
                Debug.Log("not suficientes lilas");
            }

            if(colorFlower.GetColor() == Index.BLUE && aux.GetInventory().blueCounter > 0) {
                Debug.Log("flor BLU");
                aux.handFlower4.SetActive(true);
                aux.GetInventory().SubstractFlowerToInventory(Index.BLUE);

            }
            else
            {
                Debug.Log("not suficientes blues");
                Debug.Log(aux.GetInventory().blueCounter);
            }


        }
    }
}
