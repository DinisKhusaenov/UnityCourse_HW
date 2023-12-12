using UnityEngine;

public abstract class Dealer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IBuyer buyer))
        {
            Debug.Log("�� ��������� ��������");

            Sell(buyer);
        }
    }

    protected abstract void Sell(IBuyer buyer);
}
