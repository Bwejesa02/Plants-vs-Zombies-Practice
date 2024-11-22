using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform shootPoint;
    public float projectileSpeed = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Shoot with Spacebar
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject projectile = ObjectPool.Instance.GetProjectile(); 
        projectile.transform.position = shootPoint.position;
        projectile.GetComponent<Rigidbody2D>().velocity = Vector2.right * projectileSpeed;
    }
}
