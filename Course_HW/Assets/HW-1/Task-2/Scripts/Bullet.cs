using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed;

    public void Launch(float speed)
    {
        if (speed <= 0)
            new ArgumentOutOfRangeException();

        _speed = speed;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}