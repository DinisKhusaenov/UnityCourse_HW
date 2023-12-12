using UnityEngine;

public class FruitDealer : Dealer
{
    protected override void Sell(IBuyer buyer)
    {
        buyer.Buy();
        Debug.Log("Я продаю фрукты");
    }
}
