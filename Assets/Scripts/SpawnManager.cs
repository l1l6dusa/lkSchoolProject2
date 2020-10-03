using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float _spawnTimeRange;

    private SpawnPoint[] _spawnPoints;
    private float _timePassed;

    private void Start()
    {
        _spawnPoints = GetComponentsInChildren<SpawnPoint>();
    }

    private void Update()
    {
        _timePassed += Time.deltaTime;
        if (_timePassed > _spawnTimeRange)
        {
            InitiateSpawn(Random.Range(0, _spawnPoints.Length));
            _timePassed = 0;
        }
    }

    private void InitiateSpawn(int spawnIndex)
    {
        _spawnPoints[spawnIndex].Spawn();
    }
}
