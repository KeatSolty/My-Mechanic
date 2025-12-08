using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void restartButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void mainmenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
}
