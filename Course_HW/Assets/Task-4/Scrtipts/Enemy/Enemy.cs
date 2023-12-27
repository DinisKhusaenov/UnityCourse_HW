using System;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public event Action<Enemy> Died;

    public void MoveTo(Vector3 position) => transform.position = position;

    public void Kill()
    {
        Died?.Invoke(this);
        Destroy(gameObject);
    }
}
