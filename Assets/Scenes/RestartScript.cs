using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    // Attach this method to the button click event in the Unity Editor.
    public void ButtonClick()
    {
        // Your code to be executed when the button is clicked.
        RestartGame();
    }

    void RestartGame()
    {
        // Load the first scene
        SceneManager.LoadScene("Level1");
    }
}