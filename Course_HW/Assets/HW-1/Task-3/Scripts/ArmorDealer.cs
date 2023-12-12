using UnityEngine;

public class ArmorDealer : Dealer
{
    protected override void Sell(IBuyer buyer)
    {
        buyer.Buy();
        Debug.Log("Я продаю броню");
    }
}
