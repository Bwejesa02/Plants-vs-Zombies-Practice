using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public Transform[] lanes;
    public float spawnRate = 1f;
    public int maxZombies = 100;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate && GameObject.FindGameObjectsWithTag("Zombie").Length < maxZombies)
        {
            SpawnZombie();
            timer = 0f;
        }
    }

    void SpawnZombie()
    {
        int laneIndex = Random.Range(0, lanes.Length);
        Zombie zombie = ZombieFactory.CreateZombie();
        zombie.transform.position = lanes[laneIndex].position;
    }
}
