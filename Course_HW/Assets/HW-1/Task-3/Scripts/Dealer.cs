using UnityEngine;

public abstract class Dealer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IBuyer buyer))
        {
            Debug.Log("Вы встретили торговца");

            Sell(buyer);
        }
    }

    protected abstract void Sell(IBuyer buyer);
}
