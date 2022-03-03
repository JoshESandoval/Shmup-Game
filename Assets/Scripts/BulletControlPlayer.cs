using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControlPlayer : MonoBehaviour
{
    Rigidbody2D bullet;
    public float bulletSpeed = 2;
    HealthManager HealthManager;
    // Start is called before the first frame update
    void Start()
    {
        HealthManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<HealthManager>();
        bullet = gameObject.GetComponent<Rigidbody2D>();
        bullet.velocity = new Vector2(0, bulletSpeed);
    }

    private void Update()
    {
         if(gameObject.transform.position.y > 6 || HealthManager.gameover)
        {
            Destroy(gameObject);
        } 
    }

 
}
