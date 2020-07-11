using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerMonsters : MonoBehaviour
{   
    public GameObject monster;
     void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(monster);
        SceneManager.LoadScene("UniversalSideScroll");
    }
}
