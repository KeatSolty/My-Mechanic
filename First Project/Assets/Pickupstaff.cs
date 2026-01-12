using UnityEngine;

public class Pickupstaff : MonoBehaviour
{
    public bool hasStaff = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            hasStaff = true;
        }
    }
}
