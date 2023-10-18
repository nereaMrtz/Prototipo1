using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftPotions : MonoBehaviour
{
    public GameObject handFlower1;
    public GameObject handFlower4;
    public GameObject newPotion;
    

    List<Potions> potions = new List<Potions>();
    int potionCounter = 0;

    public void OnMouseDown()
    {
      if(handFlower1.activeSelf == true && handFlower4.activeSelf == true)
        {
            handFlower1.SetActive(false);
            handFlower4.SetActive(false);

            //potions.Add(newPotion.gameObject.GetComponent<Potions>().GetPotion());
            potionCounter++;
            Debug.Log(potionCounter);

            newPotion.SetActive(true);
        }
    }

    public List<Potions> GetPotions() { return potions; }
}
