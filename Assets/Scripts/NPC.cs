using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
    [SerializeField] string election2;
    void Start()
    {
        dialogueText.text = "";

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

        }
        if (Input.GetKeyDown(KeyCode.Q) && dialoguePanel.activeInHierarchy)
        {
            RemoveText();
        }
       
    }

    public void RemoveText()
    {
        StopCoroutine(typing);
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            //StopCoroutine(typing);
            typing = StartCoroutine(Typing());
        }
        else
        {
            // Desactivar texto
            StopCoroutine(typing);
            dialogueText.text = "";
            index = 0;

            // Activar botones
            election.SetActiveButtons(election1, election2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
            Debug.Log("Player entro en collider");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            RemoveText();
        }
    }

    void EndDialog()
    {
        RemoveText();
    }
}