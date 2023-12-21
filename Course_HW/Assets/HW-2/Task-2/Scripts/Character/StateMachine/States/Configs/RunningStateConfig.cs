using System;
using UnityEngine;

[Serializable]
public class RunningStateConfig 
{
    [SerializeField, Range(0, 10)] private float _speed;
    [SerializeField, Range(0, 10)] private float _distanceToTarget;

    public float Speed => _speed;
    public float DistanceToTarget => _distanceToTarget;
}
