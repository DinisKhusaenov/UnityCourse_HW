using System;
using UnityEngine;

public class SceneLoader
{
    private readonly ZenjectSceneLoaderWrapper _zenjectSceneLoader;

    public SceneLoader(ZenjectSceneLoaderWrapper zenjectSceneLoaderWrapper)
    {
        _zenjectSceneLoader = zenjectSceneLoaderWrapper;
    }

    public void Load(GameLoadingData gameLoadingData)
    {
        _zenjectSceneLoader.Load(container =>
        {
            container.BindInstance(gameLoadingData);
        }, (int)SceneID.Gameplay);
    }

    public void Load(SceneID sceneID)
    {
        if (sceneID == SceneID.Gameplay)
            throw new ArgumentException($"{SceneID.Gameplay} cannot be started without configuration");

        _zenjectSceneLoader.Load(null, (int)sceneID);
    }
}
