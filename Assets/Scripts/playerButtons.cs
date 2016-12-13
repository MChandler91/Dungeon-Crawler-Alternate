using UnityEngine;
using System.Collections;

public class playerButtons : MonoBehaviour
{

    /// <summary>
    /// Bool to check if player is moving forward
    /// </summary>
    private bool movingForward;

    /// <summary>
    /// Bool to check if player is moving back
    /// </summary>
    private bool movingBack;

    /// <summary>
    /// Player game object
    /// </summary>
    public GameObject player;

    /// <summary>
    /// The game manager game object 
    /// </summary>
    public GameObject gMgr;

    /// <summary>
    /// The gameManager script component
    /// </summary>
    private gameManager gm;

    /// <summary>
    /// Called once at the start
    /// </summary>
    void Start()
    {
        gm = gMgr.GetComponent<gameManager>();
    }

    /// <summary>
    /// Called when the player presses the left arrow button
    /// </summary>
    public void leftBtn()
    {
        //Rotate the player object to the left
        player.transform.Rotate(0, -90, 0);
    }

    /// <summary>
    /// Called when the player presses the right arrow button
    /// </summary>
    public void rightBtn()
    {
        //Rotate the player object to the right
        player.transform.Rotate(0, 90, 0);
    }

    /// <summary>
    /// Function to determine if up button is held
    /// </summary>
    public void upHeld()
    {
        gm.UpHeld = true;
    }

    /// <summary>
    /// Function to determine if down button is held
    /// </summary>
    public void backHeld()
    {
        gm.DownHeld = true;
    }

    /// <summary>
    /// Function to determine if up button has been let go
    /// </summary>
    public void upNotHeld()
    {
        gm.UpHeld = false;
    }

    /// <summary>
    /// Function to determine if the down button has been let go
    /// </summary>
    public void backNotHeld()
    {
        gm.DownHeld = false;
    }
}
