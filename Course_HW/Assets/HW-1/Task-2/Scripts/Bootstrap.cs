using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Bootstrap : MonoBehaviour
{
    private const int OneShoot = 1;

    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Weapon _weapon;
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private Button _shootButton;
    [SerializeField] private BulletSpawner _bulletSpawner;
    [SerializeField] private List<Transform> _bulletSpawnPoints;
    [SerializeField, Range(1, 5)] private int _numberOfShoots = 3;
    [SerializeField, Range(0, 10)] private int _numberOfCartridgesFirstWeapon = 9;
    [SerializeField, Range(0, 15)] private int _numberOfCartridgesThirdWeapon = 12;
    [SerializeField] private float _bulletSpeed;

    private float _destroyTime = 5f;

    private void Awake()
    {
        _bulletSpawner.Initialize(_bulletPrefab, _destroyTime, _bulletSpeed);
        _playerInput.Initialize(_shootButton);
        _weapon.Initialize(new OneShotWithUnlimitedAmmunition(_bulletSpawner, _bulletSpawnPoints[0].position), _playerInput);
    }

    private void OnValidate()
    {
        if (_numberOfShoots > _bulletSpawnPoints.Count)
            _numberOfShoots = _bulletSpawnPoints.Count;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Оружие 1");
            _weapon.Initialize(new ShootWithLimitedAmmunition(_bulletSpawner, _numberOfCartridgesFirstWeapon, OneShoot, _bulletSpawnPoints.Select(point => point.position)), _playerInput);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Оружие 2");
            _weapon.Initialize(new OneShotWithUnlimitedAmmunition(_bulletSpawner, _bulletSpawnPoints[0].position), _playerInput);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Оружие 3");
            _weapon.Initialize(new ShootWithLimitedAmmunition(_bulletSpawner, _numberOfCartridgesThirdWeapon, _numberOfShoots, _bulletSpawnPoints.Select(point => point.position)), _playerInput);
        }
    }
}
