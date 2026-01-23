using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
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
  