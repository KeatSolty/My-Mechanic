using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class Projectile : MonoBehaviour
{
    public Rigidbody r;
    public float destroytimer = 0.2f;

    void Start()
    {
        StartCoroutine(timer());
        r = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        destroytimer -= Time.deltaTime;
        r.transform.Rotate(Vector3.down, 10);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(destroytimer <= 0)
        {
            Destroy(this.gameObject);
        }
        
    }
    public IEnumerator timer()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}

