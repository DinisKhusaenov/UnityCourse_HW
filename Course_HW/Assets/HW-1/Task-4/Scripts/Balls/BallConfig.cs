using UnityEngine;

[CreateAssetMenu(fileName = "BallConfig", menuName = "BallConfig/Ball")]
public class BallConfig : ScriptableObject
{
    [SerializeField] private Ball _prefab;

    public Ball Prefab => _prefab;
}
