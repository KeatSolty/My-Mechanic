using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
    public Light glow;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletVelocity = 30;
    public float bulletPrefabLifeTime = 3f;
    public Pmenu pmenu;

    private void Awake()
    {
        glow.GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) && pmenu.paused == false)
        {
            FireWeapon();
        }
    }

    private void FireWeapon()
    {
       GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);

        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward.normalized*bulletVelocity, ForceMode.Impulse);

        StartCoroutine(DestroyBulletAfterTime(bullet, bulletPrefabLifeTime));

        glow.intensity = 10f;
        StartCoroutine(changeGlow());

    }

    private IEnumerator DestroyBulletAfterTime(GameObject bullet, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(bullet);
    }

    private IEnumerator changeGlow()
    {
        yield return new WaitForSeconds(0.1f);
        glow.intensity = 0.23f;
    }
}
