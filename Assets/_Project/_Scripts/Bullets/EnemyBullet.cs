using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Projectile
{
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        if (other.CompareTag("Bounds"))
        {
            Destroy(gameObject);
        }
    }
}
