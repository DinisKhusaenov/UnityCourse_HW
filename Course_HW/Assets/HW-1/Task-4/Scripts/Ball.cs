using UnityEngine;

public abstract class Ball: MonoBehaviour
{
    protected ColorsEnum Color;

    public abstract ColorsEnum GetColor();
}
