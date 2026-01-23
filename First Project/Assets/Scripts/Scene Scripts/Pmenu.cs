using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pmenu : MonoBehaviour
{
    public GameObject PausePanel1;
    public GameObject controls;
    public bool paused = false;
    public bool showcontrols = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;
        }

        if (paused)
        {
            PausePanel1.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            PausePanel1.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        if(showcontrols)
        {
            controls.SetActive(true);
        }
        if(!showcontrols)
        {
            controls.SetActive(false);
        }

    }
    public void UnPause()
    {
        paused = false;
    }
   
    public void ShowControls()
    {
        showcontrols = !showcontrols;
    }
    public void mainmenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
