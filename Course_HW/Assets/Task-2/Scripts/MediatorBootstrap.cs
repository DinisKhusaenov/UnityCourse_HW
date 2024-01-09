using UnityEngine;
using Zenject;

public class MediatorBootstrap : MonoBehaviour
{
    [SerializeField] private DefeatPanel _defeatPanel;

    private Level _level;

    [Inject]
    private void Construct(Level level)
    {
        _level = level;
    }

    private void Awake()
    {
        _level.Start();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            _level.OnDefeat();
    }
}
