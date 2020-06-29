using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerComputer : MonoBehaviour
{
    public GameObject interactText;
    public GameObject dialoug;
    public Text textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    private bool triggerEntered;
    public GameObject nextButton;
    // Start is called before the first frame update
    void Start()
    {
         interactText.SetActive(false);
         dialoug.SetActive(false);
    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.E)&& triggerEntered==true&&!dialoug.activeSelf)
        {
            dialoug.SetActive(true);
            StartCoroutine(Type());
        }
        if (textDisplay.text==sentences[index])
             nextButton.SetActive(true);

        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag==("Player"))
        {
            triggerEntered=true;
            interactText.SetActive(true);
        }
    }


    
    
     void OnTriggerExit2D(Collider2D other) 
    {  
        triggerEntered=false;
        textDisplay.text = "";
        interactText.SetActive(false);
        dialoug.SetActive(false);
        index = 0;
    }

    IEnumerator Type(){
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        nextButton.SetActive(false);
        if (index<sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            nextButton.SetActive(false);
            index=0;
        }
    }
}
