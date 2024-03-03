using UnityEngine;

public class QuitScript : MonoBehaviour
{
    // Attach this method to the button click event in the Unity Editor.

    public void Click()
    {
        Exit();
      
    }
    void Exit()
    {

        Application.Quit();


    }

   
}
