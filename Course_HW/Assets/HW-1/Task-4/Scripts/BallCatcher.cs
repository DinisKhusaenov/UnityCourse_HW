using UnityEngine;

public class BallCatcher : MonoBehaviour
{
    private WinningCondition _winningCondition;

    public void Initialization(WinningCondition winningCondition)
    {
        _winningCondition = winningCondition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ball ball))
        {
            if (_winningCondition.IsWin(ball))
                Debug.Log("WIN");

            Destroy(ball.gameObject);
        }
    }
}
