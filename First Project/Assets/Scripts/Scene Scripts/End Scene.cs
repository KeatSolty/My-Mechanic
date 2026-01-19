using UnityEngine;
using System.Collections;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public GameObject End;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "End")
        {
            SceneManager.LoadScene("EndScreen");
        }
    }





}