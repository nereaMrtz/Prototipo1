using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftPotions : MonoBehaviour
{
    public GameObject handFlower1;
    public GameObject handFlower4;

    public void OnMouseDown()
    {
      if(handFlower1.activeSelf == true || handFlower4.activeSelf == true)
        {
            Debug.Log("true");
        }
    }

}
