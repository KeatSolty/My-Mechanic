using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Back2 : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    public void BackButton2()
    {
        SceneManager.LoadScene("Options");

    }
}
