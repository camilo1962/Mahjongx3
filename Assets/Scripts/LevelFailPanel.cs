using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelFailPanel : MonoBehaviour
{
    [SerializeField] private Button restartLevelButton;
    [SerializeField] private Button nivelesLevelButton;
    [SerializeField] private Button salirButton;

    private void Start()
    {
        restartLevelButton.onClick.AddListener(RestartLevel);
        nivelesLevelButton.onClick.AddListener(NivelesLevel);
        salirButton.onClick.AddListener(SalirLevel);
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void SalirLevel()
    {
        Application.Quit();
    }
    private void NivelesLevel()
    {
        SceneManager.LoadScene(1);
    }
}