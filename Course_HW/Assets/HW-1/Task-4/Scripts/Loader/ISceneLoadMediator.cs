using UnityEngine;

public interface ISceneLoadMediator
{
    void GoToMainMenu();
    void GoToGameplay(GameLoadingData gameLoadingData);
}
