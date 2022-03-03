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
    public HealthManager HealthManager;
    // Start is called before the first frame update
    void Start()
    {
        HealthManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<HealthManager>();
        enemyRB = gameObject.GetComponent<Rigidbody2D>();
        enemyRB.velocity = new Vector2(Random.Range(-1.5f,1.5f), -movementSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthManager.gameover)
        {
            Destroy(gameObject);
        }
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
