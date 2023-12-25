using TMPro;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private const string LevelText = "Ваш уровень: ";
    private const string HealthText = "Здоровье: ";

    [SerializeField] private TMP_Text _levelText;
    [SerializeField] private TMP_Text _healthText;

    public void UpdateLevelText(int currentlevel)
    {
        _levelText.text = LevelText + currentlevel.ToString();
    }

    public void UpdateHealthText(int currentHealth)
    {
        _healthText.text = HealthText + currentHealth.ToString();
    }

    public void Show()
    {
        _levelText.gameObject.SetActive(true);
        _healthText.gameObject.SetActive(true);
    }

    public void Hide()
    {
        _levelText.gameObject.SetActive(false);
        _healthText.gameObject.SetActive(false);
    }
}
