using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScreen : MonoBehaviour
{
    public void ControlsButton()
    {
        SceneManager.LoadScene("Controls");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
