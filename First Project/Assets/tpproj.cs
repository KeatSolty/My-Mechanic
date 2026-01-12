using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class tpproj : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("FirstPersonController");
        StartCoroutine(destroyProj());
    }
    private void Update()
    {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        player.transform.position = this.transform.position;
        Destroy(this.gameObject);

        
    }

    private IEnumerator destroyProj()
    {
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }
}
