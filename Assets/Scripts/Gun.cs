using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("Firing Properties")]
    public float maxProjectileForce = 180f;
    public float cooldown = 2f;

    [Header("Projectile Properties")]
    public GameObject projectilePrefab;

    Transform projectileSpawnTransform;
    bool canShoot = true;
    Animator anim;

    public SphereBehaviour sphereBehaviour;

    private void Awake()
    {
        projectileSpawnTransform = GameObject.Find("ProjectileSpawnPoint").transform;
        
        anim = GetComponent<Animator>();
    }

    public void FireProjectile()
    {
        if (!canShoot)
            return;

        GameObject go = (GameObject)Instantiate(projectilePrefab, projectileSpawnTransform.position, projectileSpawnTransform.rotation);
        Vector3 force = projectileSpawnTransform.transform.forward * maxProjectileForce;
        go.GetComponent<Rigidbody>().AddForce(force);

        canShoot = false;
        Invoke("Cooldown", cooldown);
    }

    void Cooldown()
    {
        canShoot = true;
    }
    private void Update()
    {
        //FOR PC TESTING
        /*if (Input.GetKeyDown(KeyCode.E))
        {
            FireProjectile();
        }*/

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if(Input.GetTouch(i).phase == TouchPhase.Began)
                FireProjectile();
        }
    }
}
