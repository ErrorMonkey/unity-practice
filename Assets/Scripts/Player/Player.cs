using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float health = 100.0f;

    public float Health{
        get { return health; }
    }
 
    void TakeDamage(float value) {
        health -= value;
        Debug.Log("player의 체력 "+health);

        if (health <=0)
        {
            Die();
        }
    }

    void Die() {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
            Destroy(gameObject);
        }
    }

}
