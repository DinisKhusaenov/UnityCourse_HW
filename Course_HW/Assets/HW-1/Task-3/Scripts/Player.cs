using UnityEngine;

public class Player : MonoBehaviour, IBuyer
{
    public void Buy()
    {
        Debug.Log("Какой товар продаёшь?");
    }
}
