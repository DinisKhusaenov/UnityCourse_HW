using System;
using UnityEngine;

[Serializable]
public class FastRunnigStateConfig
{
    [SerializeField, Range(10, 15)] private float _speed;

    public float Speed => _speed;
}
