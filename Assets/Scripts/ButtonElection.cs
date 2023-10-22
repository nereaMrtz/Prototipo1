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

    int election = 0; // true = 1 ; false = 2

    public void SetActiveButtons(string b1Text, string b2Text)
    {
        button1.SetActive(true);
        button2.SetActive(true);

        buttonText1.text = b1Text;
        buttonText2.text = b2Text;
    }

    void Update()
    {
        Debug.Log(election);
    }

    public void Button1()
    {
        election = 1;
    }
    public void Button2()
    {
        election = 2;   
    }

    public void ResetButtons()
    {
        election = 0;
        button1.SetActive(false);
        button2.SetActive(false);
    }

    public int GetElection()
    {
        return election;
    }

    public void SetElection(int number)
    {
        election = number;
    }

}
