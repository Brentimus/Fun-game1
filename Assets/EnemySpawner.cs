using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    float randY;
    Vector2 wheretoSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-3f, 3f);
            randY = Random.Range(-3f, 3f);
            wheretoSpawn = new Vector2(transform.position.x + randX, transform.position.y + randY);
            Instantiate(enemy, wheretoSpawn, Quaternion.identity);
        }
    }
}
