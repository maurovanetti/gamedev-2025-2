using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    public float minSpawnInterval = 3.0f;
    public float maxSpawnInterval = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SpawnRandomBall), startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[0], spawnPos, ballPrefabs[0].transform.rotation);

        // Re-invoke same method after delay
        Invoke(nameof(SpawnRandomBall), Random.Range(minSpawnInterval, maxSpawnInterval));
    }

}
