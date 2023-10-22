using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonElection : MonoBehaviour
{
    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    public TextMeshProUGUI buttonText1;
    public TextMeshProUGUI buttonText2;

    //public string textButton1;
    // Start is called before the first frame update
    public void SetActiveButtons(string b1Text, string b2Text)
    {
        button1.SetActive(true);
        button2.SetActive(true);

        buttonText1.text = b1Text;
        buttonText2.text = b2Text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button1()
    {
        Debug.Log("Opción 1");
    }
    public void Button2()
    {
        
    }
}
