using UnityEngine;

public class Character : MonoBehaviour
{
    private CharacterStats _stats;

    public void Initialize(CharacterStats stats)
    {
        _stats = stats;
    }

    public void ShowStats()
    {
        Debug.Log($"Strength: {_stats.Strength}, Intelligence: {_stats.Intelligence}, Agility: {_stats.Agility}");
    }
}
