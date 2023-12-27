using UnityEngine;

public class CoinFactory
{
    private Coin _prefab;

    public CoinFactory(Coin prefab)
    {
        _prefab = prefab;
    }

    public Coin Get(Vector3 spawnPosition)
    {
        return Object.Instantiate(_prefab, spawnPosition, Quaternion.identity);
    }
}
