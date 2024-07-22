using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    public GameObject bulletPrefab; // Bullet prefab to be assigned in the Inspector
    public Transform bulletSpawnPoint; // Bullet spawn point
    public float fireRate = 1f; // Time between shots
    public float shootingRange = 50f; // Range to detect player
    public LayerMask playerLayer; // Layer mask to identify player
    public float bulletLifeTime = 1f;

    private float nextFireTime;

    void Update()
    {
        // Check if it's time to fire
        if (Time.time >= nextFireTime)
        {
            // Use Raycast to check if player is in range
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, shootingRange, playerLayer))
            {
                // Instantiate bullet and set its direction towards player
                GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                rb.velocity = (hit.point - bulletSpawnPoint.position).normalized * 20f; // Set bullet speed
                Destroy(bullet, bulletLifeTime);

                // Set the next fire ti
                nextFireTime = Time.time + fireRate;
            }
        }
    }

    void OnDrawGizmos()
    {
        // Draw shooting range in the Editor for better visualization
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * shootingRange);
    }
}
