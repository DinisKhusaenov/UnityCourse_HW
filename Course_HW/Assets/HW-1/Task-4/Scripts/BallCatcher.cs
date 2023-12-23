using System;
using UnityEngine;

public class BallCatcher : MonoBehaviour
{
    public event Action<Ball> BallCatched;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ball ball))
        {
            BallCatched?.Invoke(ball);
            Destroy(ball.gameObject);
        }
    }
}
