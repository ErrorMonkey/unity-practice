using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{ 
    void Start()
    {
        Invoke("DestroySelf", 2.0f);
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
