using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> _cavePrefabs;
    [SerializeField] private float _speed = 30;
    [SerializeField] private int _maxCaveCount;

    private List<GameObject> _caves = new List<GameObject>();

    private void Start()
    {
        ResetLevel();
        _speed = 30;
    }

    private void Update()
    {
        if (_speed == 0)
            return;

        foreach (var cave in _caves)
        {
            cave.transform.position -= new Vector3(0, 0, _speed * Time.deltaTime);
        }

        if (_caves[0].transform.position.z < 60)
        {
            Destroy(_caves[0]);
            _caves.RemoveAt(0);

            CreateNextCave();
        }
    }

    private void ResetLevel()
    {
        _speed = 0;

        foreach (var cave in _caves)
        {
            Destroy(cave);
        }

        _caves.Clear();

        for (int i = 0; i < _maxCaveCount; i++)
        {
            CreateNextCave();
        }
    }

    private void CreateNextCave()
    {
        Vector3 position = Vector3.zero;

        if (_caves.Count > 0)
        {
            position = _caves[_caves.Count - 1].transform.position + new Vector3(0, 0, 100);
        }

        GameObject randomCavePrefab = _cavePrefabs[Random.Range(0, _cavePrefabs.Count)];

        GameObject cave = Instantiate(randomCavePrefab, position, Quaternion.identity);
        _caves.Add(cave);
    }
}
