using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum Index { BLUE, RED, WHITE, PURPLE}

public class Flower : MonoBehaviour
{
    [SerializeField] Index color;
    int prueba = 1;
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
}
