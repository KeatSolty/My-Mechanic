using UnityEngine;
using System.Collections;

public class projtp : MonoBehaviour
{
    public GameObject tpproj;
    [SerializeField] private Transform CastPoint;
    public Pmenu pmenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && pmenu.paused == false)
        {
            Instantiate(tpproj, CastPoint.position, CastPoint.rotation);
        }
    }
    
}
