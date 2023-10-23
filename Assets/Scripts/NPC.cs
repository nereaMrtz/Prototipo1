using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class NPC : MonoBehaviour
{
    [SerializeField]public GameObject dialoguePanel;
    [SerializeField] public TextMeshProUGUI dialogueText;
    [SerializeField] public string[] dialogue;
    private int index = 0;

    [SerializeField] public float wordSpeed;
    public bool playerIsClose;

    Coroutine typing;

   [SerializeField] ButtonElection election;

    [SerializeField] string election1;
    [SerializeField] string electionSinPoti;
    [SerializeField] string election2;

    [SerializeField] GameObject e;

    private AudioManager sound;

    bool potion;

    void Start()
    {
        potion = false;
         
        dialogueText.text = "";
        election.ResetButtons();
        e.SetActive(false);
        sound = GameObject.FindGameObjectWithTag("AM").GetComponent<AudioManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (!dialoguePanel.activeInHierarchy)
            {
                dialoguePanel.SetActive(true);
                typing = StartCoroutine(Typing());
               
            }
            else if (dialogueText.text == dialogue[index])
            {
               
                NextLine();
            }
            sound.select.Play();
        }
        if (Input.GetKeyDown(KeyCode.Q) && dialoguePanel.activeInHierarchy)
        {
            RemoveText();
        }


        //Cuando el botón está pulsado
        if (election.GetElection() == 1)
        {
            
            if (this.CompareTag("EvilNPC") && potion)
            {
                SceneManager.LoadScene(5); // Final malo
            }
            else if (this.CompareTag("EvilNPC") && !potion)
            {
                RemoveText();
                election.ResetButtons();
            }

            if (gameObject.tag.Equals("GoodNPC") && potion)
            {
                SceneManager.LoadScene(4); // Final bueno
            }
            else if (this.CompareTag("GoodNPC") && !potion)
            {
                RemoveText();
                election.ResetButtons();
            }

        }
        else if (election.GetElection() == 2)
        {
            //Debug.Log("Segunda opcion");
            RemoveText();
            election.ResetButtons();
        }
        else
        {
           // Debug.Log("No opcion");
        }
    }

    public void RemoveText()
    {
        if (typing != null) { StopCoroutine(typing); }
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            // Dialogue sound
            sound.voice.Play();
            yield return new WaitForSeconds(wordSpeed);
        }
        e.SetActive(true);
    }

    public void NextLine()
    {
        e.SetActive(false);

        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            typing = StartCoroutine(Typing());
        }
        else
        {
            // Desactivar texto
            if (typing != null) { StopCoroutine(typing); }
            dialogueText.text = "";
            index = 0;

            // Activar botones
            if(!potion)
            election.SetActiveButtons(electionSinPoti, election2);
            else { election.SetActiveButtons(election1, election2); }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
            Debug.Log("Player entro en collider");

            potion = other.gameObject.GetComponent<PJ_Movement>().hasPotion;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            RemoveText();
            election.ResetButtons();
        }
    }
}