using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShootWithLimitedAmmunition : IShootable
{
    private readonly int NumberOfShoots;

    private BulletSpawner _bulletSpawner;
    private int _numberOfCartridges;
    private List<Vector3> _spawnPoints;

    public ShootWithLimitedAmmunition(BulletSpawner bulletSpawner, int numberOfCartridges, int numberOfShoots, IEnumerable<Vector3> spawnPoints)
    {
        _bulletSpawner = bulletSpawner;
        _numberOfCartridges = numberOfCartridges;
        NumberOfShoots = numberOfShoots;
        _spawnPoints = spawnPoints.ToList();

        CanShoot = true;
    }

    public bool CanShoot { get; private set; }

    public void Shoot()
    {
        if (_numberOfCartridges >= NumberOfShoots && CanShoot)
        {
            for (int i = 0; i < NumberOfShoots; i++)
            {
                _bulletSpawner.CreateBullet(_spawnPoints[i]);
            }
            _numberOfCartridges -= NumberOfShoots;

            if (_numberOfCartridges < NumberOfShoots) CanShoot = false;
        }
    }
}
