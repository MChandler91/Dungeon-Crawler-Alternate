using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lossMenu : MonoBehaviour {

    /// <summary>
    /// Game over text
    /// </summary>
    public Text gameOver;

    /// <summary>
    /// Text for replay button
    /// </summary>
    public Text replay;

    /// <summary>
    /// Text for quit button
    /// </summary>
    public Text quit;

	/// <summary>
    /// Called once at the start
    /// </summary>
	void Start () {

        //Set game over and button text appropriately
        gameOver.text = "You lose!";
        replay.text = "Play again";
        quit.text = "Quit";
	}
	
}
