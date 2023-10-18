using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryFlower : MonoBehaviour
{
    public GameObject pickFlower;
    public GameObject handFlower;
    private void OnMouseDown()
    {
        if(pickFlower.tag == "flower")
        {
            Debug.Log("carry flor");
            handFlower.SetActive(true);
        }
    }
}
