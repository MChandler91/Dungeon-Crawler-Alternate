using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class winScript : MonoBehaviour {

    /// <summary>
    /// Winning text
    /// </summary>
    public Text win;

    /// <summary>
    /// Replay button text
    /// </summary>
    public Text replay;

    /// <summary>
    /// Quit button text
    /// </summary>
    public Text quit;
	
    /// <summary>
    /// Called once at the start
    /// </summary>
	void Start () {

        //Set 'win' text appropriately
        win.text = "You win!";
        replay.text = "Play again";
        quit.text = "Quit";
	}

}
