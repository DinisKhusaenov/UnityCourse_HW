using UnityEngine;

public class OneShotWithUnlimitedAmmunition : IShootable
{
    private BulletSpawner _bulletSpawner;
    private Vector3 _spawnPoint;

    public OneShotWithUnlimitedAmmunition(BulletSpawner bulletSpawner, Vector3 spawnPoint)
    {
        _bulletSpawner = bulletSpawner;
        _spawnPoint = spawnPoint;
    }

    public void Shoot()
    {
        _bulletSpawner.BulletCreation(_spawnPoint);
    }
}
