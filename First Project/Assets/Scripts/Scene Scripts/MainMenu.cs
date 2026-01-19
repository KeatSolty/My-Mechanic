using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void startButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void optionsButton()
    {
        SceneManager.LoadScene("Options");
    }
    public void quitButton()
    { 
    
    }
}
  