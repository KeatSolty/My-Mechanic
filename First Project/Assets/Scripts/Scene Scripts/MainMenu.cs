using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void startButton()
    {
        SceneManager.LoadScene("Lore");
        Cursor.lockState = CursorLockMode.None;
        
    }
    public void optionsButton()
    {
        SceneManager.LoadScene("Options");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void quitButton()
    { 
        Application.Quit();
    }
}
  