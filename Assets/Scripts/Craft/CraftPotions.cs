using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftPotions : MonoBehaviour
{
    List<Potions> potions = new List<Potions>();
    int potionCounter = 0;

    PJ_Movement pj;

    private AudioManager sound;

    private void Start()
    {
        pj = FindAnyObjectByType<PJ_Movement>();
        sound = GameObject.FindGameObjectWithTag("AM").GetComponent<AudioManager>();
    }

    public void OnMouseDown()
    {
      if (pj.handFlower1.activeSelf == true && pj.handFlower4.activeSelf == true)
        {
            pj.handFlower1.SetActive(false);
            pj.handFlower4.SetActive(false);

            //potions.Add(newPotion.gameObject.GetComponent<Potions>().GetPotion());
            potionCounter++;
            Debug.Log(potionCounter);

            pj.potion.SetActive(true);
            pj.hasPotion = true;

            // Sonidito poti
            sound.pickupPotion.Play();
        }
    }

    public List<Potions> GetPotions() { return potions; }
}
