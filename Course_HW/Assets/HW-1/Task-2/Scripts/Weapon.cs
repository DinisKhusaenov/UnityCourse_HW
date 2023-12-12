using UnityEngine;

public class Weapon : MonoBehaviour
{
    private IShootable _shootable;
    private PlayerInput _playerInput;

    public void Initialize(IShootable shootable, PlayerInput playerInput)
    {
        _shootable = shootable;
        _playerInput = playerInput;
    }

    private void OnEnable()
    {
        _playerInput.ShootButtonClicked += OnShootButtonClicked;    
    }

    private void OnDisable()
    {
        _playerInput.ShootButtonClicked += OnShootButtonClicked;
    }

    private void OnShootButtonClicked()
    {
        _shootable.Shoot();
    }
}
