using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuBtns : MonoBehaviour {

    /// <summary>
    /// Called when the player presses the replay button
    /// </summary>
    public void replay()
    {
        //Load the game scene
        SceneManager.LoadScene(0);
    }

    /// <summary>
    /// Called when the player presses the quit button
    /// </summary>
    public void quit()
    {
        //Quit the application
        Application.Quit();
    }
}
