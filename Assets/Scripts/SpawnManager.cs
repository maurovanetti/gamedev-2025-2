using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float xRange;
    public GameObject[] animalPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomBeast), 2.5f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomBeast()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new(
            Random.Range(-xRange, xRange),
            0,
            transform.position.z
        );
        Instantiate(
            animalPrefabs[animalIndex],
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation
        );
    }
}
