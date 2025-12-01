using System.Collections;
using UnityEngine;

public class SpawnElvis : MonoBehaviour
{
    public GameObject elvisPrefab;
    public Transform elvisSpawn;
    public bool spawn = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (spawn)
            {
                GameObject Elvis = Instantiate(elvisPrefab, elvisSpawn.position, Quaternion.identity);
                spawn = false;
            }
            else
            {
                spawn = true;
            }
        }
    }

}
