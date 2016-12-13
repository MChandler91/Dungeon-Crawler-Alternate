using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class reloadBtn : MonoBehaviour
{
    /// <summary>
    /// The gameManager script component
    /// </summary>
    private gameManager gm;

    /// <summary>
    /// Text to display ammo count to user
    /// </summary>
    public Text reloadText;

    /// <summary>
    /// Called once at the start
    /// </summary>
    void Start()
    {
        //Grab the gameManager script component from the Game Manager game object
        gm = GameObject.Find("Game Manager").GetComponent<gameManager>();
    }

    /// <summary>
    /// Called once per frame
    /// </summary>
    void Update ()
    {
        //Set the button text
        reloadText.text = "Reload\nAmmo: " + gm.ammoCount;
    }

    /// <summary>
    /// Called when the user presses the reload button
    /// </summary>
    public void reload()
    {

        gm.ammoCount = 6;

    }
}
