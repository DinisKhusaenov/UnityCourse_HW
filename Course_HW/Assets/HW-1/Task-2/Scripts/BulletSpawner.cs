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

    public void CreateBullet(Vector3 spawnPoint)
    {
        var bullet = Instantiate(_bulletPrefab, spawnPoint, transform.rotation);
        bullet.Launch(_bulletSpeed);

        Destroy(bullet.gameObject, _destroyTime);
    }
}
