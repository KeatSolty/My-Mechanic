using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void playgameButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
