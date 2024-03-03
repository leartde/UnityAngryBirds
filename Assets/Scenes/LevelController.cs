using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private Enemy[] _enemies;

    // Start is called before the first frame update
    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        bool allEnemiesDead = true;

        foreach (Enemy enemy in _enemies)
        {
            if (enemy != null)
            {
                allEnemiesDead = false;
                break;
            }
        }

        if (allEnemiesDead)
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        // Assuming your scenes are named "Level1", "Level2", "Level3", ...
        string currentSceneName = SceneManager.GetActiveScene().name;
        int currentLevel = int.Parse(currentSceneName.Substring("Level".Length));

        // Load the next level
        int nextLevel = currentLevel + 1;
        string nextLevelName = "Level" + nextLevel;
        SceneManager.LoadScene(nextLevelName);
    }
}
