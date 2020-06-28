using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TriggerComputer : MonoBehaviour
{
    public GameObject interactText;
    public GameObject dialoug;
    public Text textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    // Start is called before the first frame update
    void Start()
    {
         interactText.SetActive(false);
         dialoug.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag==("Player"))
        {
            interactText.SetActive(true);
        }
    }

    void OnTriggerStay2D(Collider2D other) {
            
        if (Input.GetKeyDown(KeyCode.E))
        {
            dialoug.SetActive(true);
            StartCoroutine(Type());
        }
        
    }
    
    
     void OnTriggerExit2D(Collider2D other) 
    {  
         interactText.SetActive(false);
         dialoug.SetActive(false);
    }

    IEnumerator Type(){
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
