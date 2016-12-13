using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    /// <summary>
    /// Used to display the current score of the player
    /// </summary>
    public Text displayScore;

    /// <summary>
    /// Used to display the current high score
    /// </summary>
    public Text displayHscore;

    /// <summary>
    /// The integer value of the high score
    /// </summary>
    private int highScore;

    /// <summary>
    /// The integer value of the player's score
    /// </summary>
    private int score;

    /// <summary>
    /// gameManager script
    /// </summary>
    private gameManager gm;

	/// <summary>
    /// Called once at the start
    /// </summary>
	void Start () {

        //Set the screen's sleep timeout and orientation 
        //so that the device never goes to sleep while the application
        //is open, and so that the view mode is constantly set to "landscape"
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.orientation = ScreenOrientation.Landscape;

        //Set the score to zero
        score = 0;

        //Set the high score by referencing the player's preferences
        //from other game sessions
        highScore = PlayerPrefs.GetInt("High Score");

        //Grab the gameManager script from the game manager object
        gm = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<gameManager>();

    }

    /// <summary>
    /// Will be called when a collision occurs with a trigger object
    /// </summary>
    /// <param name="col"></param>
    void OnTriggerEnter(Collider col) {

        //If the trigger object's tag is "exit" 
        //set the high score and load the win scene
        if (col.CompareTag("exit"))
        {
            PlayerPrefs.SetInt("High Score", highScore);
            SceneManager.LoadScene(2);
        }

        //If the trigger objects' tag is "coin"
        //increment the player's score and destroy the 
        //coin object
        if (col.CompareTag("coin"))
        {
            score++;
            Destroy(col.gameObject);
        }

    }

    /// <summary>
    /// Is called every fixed framerate frame
    /// </summary>
    void FixedUpdate () {

        //Set the score and high score display text appropriately
        displayScore.text = "Score: " + score;
        displayHscore.text = "High score: " + highScore;

        //If UpHeld is true, move the player forward
        if(gm.UpHeld)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * 50);
        }

        ////If DownHeld is true, move the player backward
        if (gm.DownHeld)
        {
            GetComponent<Rigidbody>().AddForce((transform.forward * -1) * 50);
        }

        //If rStrfHeld is true, move the player right
        if (gm.rStrfHeld)
        {
            GetComponent<Rigidbody>().AddForce(transform.right * 25);
        }

        //If lStrfHeld is true, move the player left
        if (gm.lStrfHeld)
        {
            GetComponent<Rigidbody>().AddForce((transform.right * -1) * 25);
        }

        //If the player's score goes above the current high score
        //set the new high score
        if (score > highScore)
        {
            highScore = score;
        }

        //If the player's life drops to or below zero
        //then load the game over scene
        if(gm.PlayerLife <= 0)
        {
           SceneManager.LoadScene(1);
        }
	}
}
