using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public GameObject dialougeBox;
    public GameObject continueButton;
    public Text dialougeText;
    public string[] dialouge;

    private int index;
    public float wordSpeed;

    public bool playerClose;


    // Start is called before the first frame update
    void Start()
    {
        dialougeText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerClose ) 
        {
            if (dialougeBox.activeInHierarchy)
            {
                NoText();
            }
            else
            {
                dialougeBox.SetActive(true);
                StartCoroutine(Typing());
            }
        }

        if(dialougeText.text == dialouge[index])
        {
            continueButton.SetActive(true);
        }

    }

    public void NextLine()
    {
        continueButton.SetActive(false);

        if(index < dialouge.Length - 1) 
        {
            index++;
            dialougeText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            NoText();
        }
    }

    public void NoText()
    {
        dialougeText.text = "";
        index = 0;
        dialougeBox.SetActive(false);
    }

    IEnumerator Typing ()
    {
        foreach(char letter in dialouge[index].ToCharArray())
        {
            dialougeText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerClose = false;
            NoText();
        }
    }
}
