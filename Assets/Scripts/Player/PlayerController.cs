//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject BulletPrefab;
    public float bulletSpeed = 100f;
    public float speed = 0.01f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject bullet = Instantiate(BulletPrefab);

                Vector3 bulletStartPos = transform.position + new Vector3(0, 0.2f, 0);
                bulletStartPos.y += i * 0.2f;
                bullet.transform.position = bulletStartPos;

                bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);
            }
        }

    }
}
