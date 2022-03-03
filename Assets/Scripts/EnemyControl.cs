using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float movementSpeed = 2,
                 shootSpeed =0,
                 shootInterval = 0.9f;
    Rigidbody2D enemyRB;
    public GameObject enemyBullet;
    public GameObject[] GunsE;
    // Start is called before the first frame update
    void Start()
    {

        enemyRB = gameObject.GetComponent<Rigidbody2D>();
        enemyRB.velocity = new Vector2(0, -movementSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        shootSpeed += Time.deltaTime;
        if(shootSpeed > shootInterval)
        {
            foreach(GameObject x in GunsE)
            {
                Instantiate(enemyBullet, x.transform.position, x.transform.rotation);
                shootSpeed = 0;
            }
        }
        if(gameObject.transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
