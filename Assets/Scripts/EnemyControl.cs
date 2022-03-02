using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float movementSpeed = 2,
                 shootSpeed = 0.5f;
    Rigidbody2D enemyRB;
    GameObject enemyBullet;
    GameObject[] GunsE;
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
        if(shootSpeed > Time.deltaTime)
        {
            foreach(GameObject x in GunsE)
            {
                Instantiate(enemyBullet, x.transform.position, x.transform.rotation);
            }
        }
    }
}
