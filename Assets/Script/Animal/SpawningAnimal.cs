using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningAnimal : MonoBehaviour
{
    public GameObject[] prefabAnimal;
    public GameObject areaSpawn;
    public Vector3 area = new Vector3(0,0,0);


    //time
    public float startTime;
    public bool GameOver;

    public bool spawnAnimal;
    public float spawnInterval = 2f;
    public float timeSpawn = 0f;

    void Start()
    {
        area = areaSpawn.transform.position;
    }

    void Update()
    {
        startTime -= Time.deltaTime;
        timeSpawn -= Time.deltaTime;

        if(Time.time >= timeSpawn)
        {
            Spawn();
            // timeSpawn = 1.2f;
            Debug.Log("spawn");
            spawnAnimal = false;
            timeSpawn = Time.time + spawnInterval;
        }

        if(startTime == 0)
        {
            GameOver = true;
            return;
        }
    }

    public void Spawn()
    {
        if(spawnAnimal == false)
        {
            GameObject sp = prefabAnimal[Random.Range(0, prefabAnimal.Length)];

            // Vector3 spawnPosition = new Vector3(Random.Range(area.x / 2, area.z / 2),0,0);
            var random = Random.Range(area.x, area.z);
            Vector3 spawnPosition = new Vector3(random, 0, 0);
            Instantiate(sp, spawnPosition, Quaternion.identity);

            spawnAnimal = true;
        }
            
    }


}
