using UnityEngine;

public class switchweapon : MonoBehaviour
{
    public GameObject gunwand;
    public GameObject tpstaff;
    private GameObject tpstaff_instantiated;
    public bool hasStaff = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "staff")
        {
            hasStaff = true;
            Destroy(tpstaff_instantiated);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            tpstaff.SetActive(false);
            gunwand.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2) && hasStaff)
        {
            gunwand.SetActive(false);
            tpstaff.SetActive(true);
        }

        tpstaff_instantiated = GameObject.FindGameObjectWithTag("staff");
    }
}
