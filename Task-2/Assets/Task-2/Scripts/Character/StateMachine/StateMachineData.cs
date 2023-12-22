using System;
using UnityEngine;

public class StateMachineData
{
    public Vector3 TargetPosition;

    private float _speed;
    private float _xInput;
    private float _distanceToTarget;

    public float XInput
    {
        get { return _xInput; }
        set
        {
            if (value < -1 || value > 1)
                throw new ArgumentOutOfRangeException(nameof(value));

            _xInput = value;
        }
    }

    public float Speed
    {
        get { return _speed; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _speed = value;
        }
    }

    public float DistanceToTarget
    {
        get { return _distanceToTarget; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _distanceToTarget = value;
        }
    }
}
