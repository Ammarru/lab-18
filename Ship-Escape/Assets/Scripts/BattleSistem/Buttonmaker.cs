using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonmaker : MonoBehaviour
{
    public GameObject btn;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
    void OnMouseDown()
    {
        btn.SetActive(true);
    }
}
