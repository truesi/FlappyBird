using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate;
    private float timer = 0;
    public float heightOffset = 10;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } 
        else
        {
            if (logic.playerScore == 2)
            {
                spawnRate = logic.increaseSpawnRate(spawnRate);
            }
            SpawnPipe();
            timer = 0;
        }
    }

    public void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(
            pipe, 
            new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), 
            transform.rotation
        );
    }
}
