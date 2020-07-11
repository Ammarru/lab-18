using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class asdas : MonoBehaviour
{
    public GameObject monster;
     void OnTriggerEnter2D(Collider2D other)
    {
        
        SceneManager.LoadScene("FrstBattle");
    }
}
