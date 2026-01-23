using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void restartButton()
    {
        SceneManager.LoadScene("MainScene");
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }
    public void mainmenuButton()
    {
        SceneManager.LoadScene("Menu");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
