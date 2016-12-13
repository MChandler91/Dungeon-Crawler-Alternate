using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class strafeScript : MonoBehaviour {

    /// <summary>
    /// The player game object
    /// </summary>
    public GameObject player;

    /// <summary>
    /// The left strafe button's text
    /// </summary>
    public Text leftStrafe;

    /// <summary>
    /// The right strafe button's text
    /// </summary>
    public Text rightStrafe;

    /// <summary>
    /// The game manager game object
    /// </summary>
    public GameObject gMgr;

    /// <summary>
    /// The gameManager script component
    /// </summary>
    private gameManager gm;

    /// <summary>
    /// Called once at start
    /// </summary>
    void Start()
    {
        //Grab the gameManager script component 
        gm = gMgr.GetComponent<gameManager>();
    } 

    /// <summary>
    /// Called once per frame
    /// </summary>
    void Update ()
    {
        //Set the text for the buttons appropriately
        leftStrafe.text = "Strafe\nLeft";
        rightStrafe.text = "Strafe\nRight";
    }

    /// <summary>
    /// Called when the user presses the right strafe button
    /// </summary>
    public void strafeRBtnOn()
    {
        gm.rStrfHeld = true;
    }

    /// <summary>
    /// Determines when right strafe button is let go
    /// </summary>
    public void strafeRBtnOff()
    {
        gm.rStrfHeld = false;
    }

    /// <summary>
    /// Called when the user presses the left strafe button
    /// </summary>
    public void strafeLBtnOn()
    {
        gm.lStrfHeld = true;
    }

    /// <summary>
    /// Determines when left strafe button is let go
    /// </summary>
    public void strafeLBtnOff()
    {
        gm.lStrfHeld = false;
    }
}
