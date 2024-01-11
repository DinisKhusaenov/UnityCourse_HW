public class SceneLoadMediator : ISceneLoadMediator
{
    private SceneLoader _sceneLoader;

    public SceneLoadMediator(SceneLoader sceneLoader)
    {
        _sceneLoader = sceneLoader;
    }

    public void GoToGameplay(GameLoadingData gameLoadingData)
    {
        _sceneLoader.Load(gameLoadingData);
    }

    public void GoToMainMenu()
    {
        _sceneLoader.Load(SceneID.MainMenu);
    }
}
