using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D player;
    public float movementSpeed = 0;
    public GameObject bullet;
    public GameObject[] Guns;
    float coolDown = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        coolDown += Time.deltaTime;
        player.velocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, Input.GetAxis("Vertical") * movementSpeed) ;
        if (Input.GetKey(KeyCode.Space))
        {
            if (coolDown > 0.25)
            {
                foreach (GameObject x in Guns)
                    Instantiate(bullet, x.transform.position, x.transform.rotation);
                coolDown = 0;    
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            Debug.Log(other.gameObject.tag);
            Destroy(other.gameObject);
        }
    }
}
