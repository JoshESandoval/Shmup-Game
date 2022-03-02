using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControlPlayer : MonoBehaviour
{
    Rigidbody2D bullet;
    public float bulletSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        bullet = gameObject.GetComponent<Rigidbody2D>();
        bullet.velocity = new Vector2(0, bulletSpeed);
    }

    private void Update()
    {
         if(gameObject.transform.position.y > 6)
        {
            Destroy(gameObject);
        } 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(collision.collider);
        }
      
    }
}
