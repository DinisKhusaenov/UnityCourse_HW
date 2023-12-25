using System;
using UnityEngine;

[Serializable]
public class HealthConfig
{
    [SerializeField, Range(3, 5)] private int _maxHealth;

    public int MaxHealth => _maxHealth;
}
