using UnityEngine;

public class switchweapon : MonoBehaviour
{
    public GameObject gunwand;
    public GameObject tpstaff;
    public Pickupstaff ps;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            tpstaff.SetActive(false);
            gunwand.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2) && ps.hasStaff)
        {
            gunwand.SetActive(false);
            tpstaff.SetActive(true);
        }
    }
}
