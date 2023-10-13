using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

enum Color { BLUE, RED, WHITE}

public class Flower : MonoBehaviour
{
    [SerializeField] Color color;
    int prueba = 1;
    Flower(Color color)
    {
        this.color = color;
    }

    public int GetPrueba() { return prueba; }
}
