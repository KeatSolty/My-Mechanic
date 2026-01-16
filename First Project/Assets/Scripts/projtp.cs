using UnityEngine;
using System.Collections;

public class projtp : MonoBehaviour
{
    public GameObject tpproj;
    [SerializeField] private Transform CastPoint;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(tpproj, CastPoint.position, CastPoint.rotation);
        }
    }
    
}
