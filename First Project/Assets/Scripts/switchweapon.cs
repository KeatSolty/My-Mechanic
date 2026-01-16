using UnityEngine;

public class switchweapon : MonoBehaviour
{
    public GameObject gunwand;
    public GameObject tpstaff;
    private GameObject tpstaff_instantiated;
    public bool hasStaff = false;
    public GameObject selector1;
    public GameObject selector2;

    private void Start()
    {
        selector1.SetActive(true);
        selector2.SetActive(false);
    }
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
            selector1.SetActive(true);
            selector2.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2) && hasStaff)
        {
            gunwand.SetActive(false);
            tpstaff.SetActive(true);
            selector1.SetActive(false);
            selector2.SetActive(true);
        }

        tpstaff_instantiated = GameObject.FindGameObjectWithTag("staff");
    }
}
