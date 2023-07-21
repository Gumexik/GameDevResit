using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform shootingStartingPoint; // Reference to the weapon's muzzle transform
    public GameObject bulletPrefab; // Prefab of the bullet
    public float bulletSpeed = 6f; // Speed of the bullet

     private bool isMouseDown = false;

     private float lastTimeShot = 0.2f;

     [SerializeField] private AudioSource shoot;

    private void Update()
    {
        if(Input.GetButton("Fire1"))
        {
        Shoot();
        shoot.enabled = true;
        }
        else {
            shoot.enabled = false;
        }
    }

    private void Shoot()
    {
        if (shootingStartingPoint != null) {

    if (lastTimeShot + bulletSpeed <= Time.time)
    {
        lastTimeShot = Time.time;
        Instantiate(bulletPrefab, shootingStartingPoint.position, shootingStartingPoint.rotation);
    }
    }
        }
}

