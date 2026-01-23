using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;

    }
    public void startButton()
    {
        SceneManager.LoadScene("Lore");
        
    }
    public void optionsButton()
    {
        SceneManager.LoadScene("Options");
    }
    public void quitButton()
    { 
        Application.Quit();
    }
}
  