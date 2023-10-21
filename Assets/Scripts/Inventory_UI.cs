using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Inventory_UI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI blue;
    [SerializeField] TextMeshProUGUI red;
    [SerializeField] TextMeshProUGUI white;
    [SerializeField] TextMeshProUGUI purple;


    public int blueCounter =2;
    public int redCounter =0;
    public int whiteCounter =0;
    public int purpleCounter=0;

   void AddPurpleFlower()
    {
      purple.text += 1;
    }
    private void Start()
    {
        //blue.text = blueCounter;
        //red.text = redCounter.ToString();
        //white.text = whiteCounter.ToString();
        //purple.text = purpleCounter.ToString();

        //Debug.Log(blue.text);
    }

    public void AddFlowerToInventory(Index color)
    {
        switch (color)
        {
            case Index.BLUE:
                blueCounter++;
                blue.text = blueCounter.ToString();
                break;
            case Index.RED:
                redCounter++;
                red.text = redCounter.ToString();
                break;
            case Index.WHITE:
                whiteCounter++; 
                white.text = whiteCounter.ToString();
                break;
            case Index.PURPLE: 
                purpleCounter++;
                purple.text = purpleCounter.ToString();
                break;
        }
    }

    public void SubstractFlowerToInventory(Index color)
    {
        switch (color)
        {
            case Index.BLUE:
                blueCounter--;
                blue.text = blueCounter.ToString();
                break;
            case Index.RED:
                redCounter--;
                red.text = redCounter.ToString();
                break;
            case Index.WHITE:
                whiteCounter--; 
                white.text = whiteCounter.ToString();
                break;
            case Index.PURPLE: 
                purpleCounter--;
                purple.text = purpleCounter.ToString();
                break;
        }
    }
 
}
