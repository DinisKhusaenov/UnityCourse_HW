using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Button _lifeEnergy;
    [SerializeField] private Button _deathEnergy;

    public event Action<EnergyFormType> EnergyButtonClick;

    private void OnEnable()
    {
        _lifeEnergy.onClick.AddListener(() => OnEnergyButtonClick(EnergyFormType.LifeForm));
        _deathEnergy.onClick.AddListener(() => OnEnergyButtonClick(EnergyFormType.DeathForm));
    }

    private void OnDisable()
    {
        _lifeEnergy.onClick.RemoveListener(() => OnEnergyButtonClick(EnergyFormType.LifeForm));
        _deathEnergy.onClick.RemoveListener(() => OnEnergyButtonClick(EnergyFormType.DeathForm));
    }

    private void OnEnergyButtonClick(EnergyFormType energyFormType)
    {
        EnergyButtonClick?.Invoke(energyFormType);
    }
}
