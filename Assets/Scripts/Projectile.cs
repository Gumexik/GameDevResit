using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 firingPoint;

    [SerializeField] private float projectileSpeed;

    [SerializeField] private float maxProjectileDistance;


    void Start()
    {
        firingPoint = transform.position;   
    }

    void Update()
    {
        moveProjectile();
    }

    private void OnCollisionEnter(Collision collision) {
         
            if (collision.transform.tag == "Enemy")
        {
            // do damage here, for example:
            collision.gameObject.GetComponent<Enemy>().TakeDamage(2);
        }
            Destroy(this.gameObject);
    }


    void moveProjectile() {
        if (Vector3.Distance(firingPoint, transform.position) > maxProjectileDistance) {
            Destroy(this.gameObject);
        }
        else {
            transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
        }

    }
}
