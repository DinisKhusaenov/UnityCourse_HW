using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerData
{
    private float _spawnCooldown;
    private List<Transform> _spawnPoints;
    private MonoBehaviour _context;

    public EnemySpawnerData(float spawnCooldown, List<Transform> spawnPoints, MonoBehaviour context)
    {
        _spawnCooldown = spawnCooldown;
        _spawnPoints = spawnPoints;
        _context = context;
    }

    public float SpawnCooldown => _spawnCooldown;
    public List<Transform> SpawnPoints => _spawnPoints;
    public MonoBehaviour Context => _context;
}
