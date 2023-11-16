using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private const string Water = "Water";
    private const string Torch = "Torch";

    [SerializeField] private List<Transform> _waterSpawnPoints;
    [SerializeField] private List<Transform> _torchSpawnPoints;
    [SerializeField] private List<GameObject> _waterPrefabs;
    [SerializeField] private List<GameObject> _torchPrefabs;

    void Start()
    {
        if (_waterPrefabs != null)
            SpawnWater();
        if (_torchPrefabs != null)
            SpawnTorches();
    }

    void SpawnWater()
    {
        SpawnObjects(_waterSpawnPoints, _waterPrefabs, Water);
    }

    void SpawnTorches()
    {
        SpawnObjects(_torchSpawnPoints, _torchPrefabs, Torch);
    }

    void SpawnObjects(List<Transform> spawnPoints, List<GameObject> prefabs, string objectName)
    {
        if (spawnPoints.Count == 0 || prefabs.Count == 0)
        {
            return;
        }

        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count)];
        GameObject prefab = prefabs[Random.Range(0, prefabs.Count)];

        Quaternion randomRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);

        GameObject spawnableObject = Instantiate(prefab, spawnPoint.position, randomRotation, transform);
    
        ISpawnable spawnableComponent = spawnableObject.GetComponent<ISpawnable>();

        spawnableObject.name = objectName;
    }
}
