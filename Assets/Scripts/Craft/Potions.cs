using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PotionType { HEAL, DAMAGE}

public class Potions : MonoBehaviour
{
    [SerializeField] PotionType type;
    //Color colorInv;

    //private void Start()
    //{
    //    switch (type) {
    //        case PotionType.HEAL:
    //            colorInv = Color.green;
     //           break;
     //       case PotionType.DAMAGE: 
    //            colorInv = Color.red;
     //           break;
     //   }
    //}

    Potions(PotionType type)
    {
        this.type = type;
    }

    public PotionType GetType(){
        
        return type; }

    public Potions GetPotion()
    {
        return new Potions(this.type);
    }
    //public Color GetColorInv() { return colorInv; }
}
