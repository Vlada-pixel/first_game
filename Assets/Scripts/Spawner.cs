using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private byte minSpawnCount = 1;
    [SerializeField] private byte maxSpawnCount = 5;
    [SerializeField] private float spawnInterval = 0f;

    private void Start()
    {
        if (spawnInterval > 0)
            StartCoroutine(GenerateWithDelay());
        else
            GenerateInstant();
    }

    private void GenerateInstant()
    {
        int countToSpawn = Random.Range(minSpawnCount, maxSpawnCount + 1);
        countToSpawn = Mathf.Min(countToSpawn, spawnPoints.Length);
        for (int i = 0; i < countToSpawn; i++)
        {
            Instantiate(prefab, spawnPoints[i].position, Quaternion.identity);
        }
    }

    private IEnumerator GenerateWithDelay()
    {
        int countToSpawn = Random.Range(minSpawnCount, maxSpawnCount + 1);
        countToSpawn = Mathf.Min(countToSpawn, spawnPoints.Length);
        for (int i = 0; i < countToSpawn; i++)
        {
            Instantiate(prefab, spawnPoints[i].position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
