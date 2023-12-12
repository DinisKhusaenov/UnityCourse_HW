using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    private Bullet _bulletPrefab;
    private float _destroyTime;
    private float _bulletSpeed;

    public void Initialize(Bullet bulletPrefab, float destroyTime, float bulletSpeed)
    {
        _bulletPrefab = bulletPrefab;
        _destroyTime = destroyTime;
        _bulletSpeed = bulletSpeed;
    }

    public void BulletCreation(Vector3 spawnPoint)
    {
        var newBullet = Instantiate(_bulletPrefab, spawnPoint, transform.rotation);
        newBullet.Speed = _bulletSpeed;

        Destroy(newBullet.gameObject, _destroyTime);
    }
}
