using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause_menu : MonoBehaviour
{
    public static bool GameisPause = false;
    public GameObject pausemenuui;
    void Start()
    {
        resume();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPause)
            {
                resume();
            }
            else
            {
                pausemenu();
            }
        }

    }
   public void resume()
    {
        pausemenuui.SetActive(false);
        Time.timeScale = 1f;
        GameisPause = false;
    }
    void pausemenu()
    {
        pausemenuui.SetActive(true);
        Time.timeScale = 0f;
        GameisPause = true;
    }
    public void Loadmenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void reset()
    {
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
        resume();



    }


}
