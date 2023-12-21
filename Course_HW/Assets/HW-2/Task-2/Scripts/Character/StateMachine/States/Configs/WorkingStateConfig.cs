using System;
using UnityEngine;

[Serializable]
public class WorkingStateConfig 
{
    [SerializeField, Range(2, 10)] private float _workingTime;

    public float WorkingTime => _workingTime;
}
