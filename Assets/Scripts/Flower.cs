using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public enum Index { BLUE, RED, WHITE, PURPLE}

public class Flower : MonoBehaviour
{
    [SerializeField] Index color;
    int prueba = 1;
    Color colorInv;

    private void Start()
    {
        switch (color) {
            case Index.BLUE:
                colorInv = Color.blue;
                break;
            case Index.RED: 
                colorInv = Color.red; 
                break;
            case Index.WHITE: 
                colorInv = Color.white;  
                break;
            case Index.PURPLE:
                colorInv = Color.magenta;
                break;

        }
    }

    Flower(Index color)
    {
        this.color = color;
    }

    public Index GetColor(){
        
        return color; }

    public Flower GetFlower()
    {
        return new Flower(this.color);
    }
    public Color GetColorInv() { return colorInv; }
}
