using System;
using UnityEngine;
using UnityEngine.UI;

public class CoinExample : MonoBehaviour
{
    [SerializeField] PlayerInput _input;
    [SerializeField] EnergyConfig _energyConfig;
    [SerializeField] private Image _icon;

    private Energy _energy;
    private EnergyFormFactory _energyFormFactory;

    private void Awake()
    {
        _energy = new Energy();
    }

    private void OnEnable()
    {
        _input.EnergyButtonClick += ChangeEnergyIcon;
    }

    private void OnDisable()
    {
        _input.EnergyButtonClick -= ChangeEnergyIcon;
    }

    private void ChangeEnergyIcon(EnergyFormType type)
    {
        switch (type)
        {
            case EnergyFormType.DeathForm:
                _energyFormFactory = new DeathEnergyFormFactory(_energyConfig, _icon);
                break;

            case EnergyFormType.LifeForm:
                _energyFormFactory = new LifeEnergyFormFactory(_energyConfig, _icon);
                break;

            default:
                throw new InvalidOperationException(nameof(type));
        }

        _energy.ChangeIcon(_energyFormFactory.Get());
    }
}
