using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Atach : MonoBehaviour
{
    public GameObject[] objects;
    private int ChrckrHealth = 100;
    private int EnemyHealth = 60;
    private int actions = 1;
    private Buttonmaker cntrlr;
   // public GameObject chkcr;

    // Start is called before the first frame update
    void Start()
    {
       cntrlr = objects[4].GetComponent<Buttonmaker>();
    }
    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth <= 0) SceneManager.LoadScene("Starter");
    }
    public void MainAttack()
    {
        objects[0].SetActive(false);
        objects[4].SetActive(false);
        objects[3].SetActive(false);
        objects[1].SetActive(true);
        objects[2].SetActive(true);
        EnemyHealth = EnemyHealth - 10;
        StartCoroutine(BckToNormal());
        objects[7].SetActive(true);
        cntrlr.enabled = !cntrlr.enabled;
    }
    public void EnemyAttack()
    {
        objects[0].SetActive(false);
        objects[4].SetActive(false);
        objects[3].SetActive(false);
        objects[5].SetActive(true);
        objects[6].SetActive(true);
        ChrckrHealth = ChrckrHealth - 6;
        StartCoroutine(BckToNormal());
        objects[7].SetActive(false);
        cntrlr.enabled = !cntrlr.enabled;
    }
    IEnumerator BckToNormal()
    {
        yield return new WaitForSeconds(1f);
        objects[4].SetActive(true);
        objects[3].SetActive(true);   
        objects[1].SetActive(false);
        objects[2].SetActive(false);
        objects[5].SetActive(false);
        objects[6].SetActive(false);
    }

}
