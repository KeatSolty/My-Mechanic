using UnityEngine;
using UnityEngine.SceneManagement;

public class Back1 : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    public void BackButton1()
    {
        SceneManager.LoadScene("Menu");

    }
}
