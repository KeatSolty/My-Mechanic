using System;
using UnityEngine;

public class TPscroll : MonoBehaviour
{
    public GameObject Scroll;
    public bool cooldown;
    public GameObject player;
    void Start()
    {
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            player.transform.position += player.transform.forward * 10;
            Debug.Log("stfu");
        }
      

    }
}
