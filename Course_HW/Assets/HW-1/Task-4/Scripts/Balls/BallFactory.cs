using System;
using System.ComponentModel;
using System.IO;
using UnityEngine;
using Zenject;

public class BallFactory
{
    private const string BlueBall = "BlueBall";
    private const string WhiteBall = "WhiteBall";
    private const string RedBall = "RedBall";

    private const string ConfigsPath = "BallConfigs";

    private BallConfig _blueBall, _whiteBall, _redBall;

    private DiContainer _diContainer;

    public BallFactory(DiContainer diContainer)
    {
        _diContainer = diContainer;
        Load();
    }

    public Ball Get(ColorsEnum color)
    {
        BallConfig ballConfig = GetConfig(color);
        Ball instance = _diContainer.InstantiatePrefabForComponent<Ball>(ballConfig.Prefab);
        return instance;
    }

    private BallConfig GetConfig(ColorsEnum color)
    {
        switch (color)
        {
            case ColorsEnum.Red:
                return _redBall;

            case ColorsEnum.White:
                return _whiteBall;

            case ColorsEnum.Blue:
                return _blueBall;

            default:
                throw new ArgumentException(nameof(color));
        }
    }

    private void Load()
    {
        _blueBall = Resources.Load<BallConfig>(Path.Combine(ConfigsPath, BlueBall));
        _whiteBall = Resources.Load<BallConfig>(Path.Combine(ConfigsPath, WhiteBall));
        _redBall = Resources.Load<BallConfig>(Path.Combine(ConfigsPath, RedBall));
    }
}
