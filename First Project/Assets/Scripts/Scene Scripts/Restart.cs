using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;


    }
    public void restartButton()
    {
        SceneManager.LoadScene("MainScene");
     
    }
    public void mainmenuButton()
    {
        SceneManager.LoadScene("Menu");
        
    }

}
