using UnityEngine;
using System.Collections;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] fruits;
    [SerializeField] private float respawnTime = 5f;

    private GameObject currentFruit;

    private void Start()
    {
        foreach (var f in fruits)
            f.SetActive(false);

        StartCoroutine(SpawnFruitsRoutine());
    }

    private IEnumerator SpawnFruitsRoutine()
    {
        while (true)
        {
            SpawnRandomFruit();
            yield return new WaitForSeconds(respawnTime);
        }
    }

    private void SpawnRandomFruit()
    {
        if (currentFruit != null)
            currentFruit.SetActive(false);

        int index = Random.Range(0, fruits.Length);
        currentFruit = fruits[index];
        currentFruit.SetActive(true);
    }
}
