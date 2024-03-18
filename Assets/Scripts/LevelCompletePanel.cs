using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelCompletePanel : MonoBehaviour
{
    [SerializeField] private Button restartLevelButton;
    [SerializeField] private Button nextLevelButton;
    [SerializeField] private Button menuLevelButton;

    private void Start()
    {
        restartLevelButton.onClick.AddListener(RestartLevel);
        nextLevelButton.onClick.AddListener(NextLevel);
        menuLevelButton.onClick.AddListener(MenuLevel);
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void NextLevel()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        if (index < 3) SceneManager.LoadScene(index + 1);
        else SceneManager.LoadScene(0);
    }
    private void MenuLevel()
    {
        SceneManager.LoadScene(1);
    }
}