using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float spawnInterval = 6,
                 lastSpawn     = 0,
                 maxSpawn      =  5;
    public GameObject[] Enemys;


    // Start is called before the first frame update
    void Start()
    {
        StartSpawn(Mathf.RoundToInt(Random.value * maxSpawn));
    }

    // Update is called once per frame
    void Update()
    {
        lastSpawn += Time.deltaTime;
        if(lastSpawn > spawnInterval)
        {
            StartSpawn( Mathf.RoundToInt(Random.value * maxSpawn) );
            lastSpawn = 0;
        }
    }

    public void StartSpawn(int numSpawn)
    {
        for(int i = 0; i < numSpawn; i++)
        {
            GameObject enemy = Instantiate(Enemys[Mathf.RoundToInt(Random.value * 1.5f)]);
            enemy.transform.position = new Vector3((Random.Range(-5, 5)), 7, 0);
        }
    }
}
