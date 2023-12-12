using UnityEngine;

public class NotTradingWithPlayers : Dealer
{
    protected override void Sell(IBuyer buyer)
    {
        buyer.Buy();
        Debug.Log("Не торгую с простолюдинами!");
    }
}
