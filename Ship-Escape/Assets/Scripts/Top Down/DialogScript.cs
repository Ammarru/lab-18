using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogScript : MonoBehaviour
{
   
    public GameObject dialoug;
    public Text textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    //private bool triggerEntered;
    public GameObject nextButton;
    // Start is called before the first frame update
    void Start()
    {
         dialoug.SetActive(false);
    }

    void Update() 
    {
        // if (triggerEntered==true&&!dialoug.activeSelf)
        // {
            
        // }
        if (textDisplay.text==sentences[index])
             nextButton.SetActive(true);

        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag==("Player"))
        {
            if (index<sentences.Length -1)
            {
            dialoug.SetActive(true);
            // Time.timeScale = 0;
            StartCoroutine(Type());
            }
            
        }
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
            // Time.timeScale = 1;
            dialoug.SetActive(false);
        }
    }
}
