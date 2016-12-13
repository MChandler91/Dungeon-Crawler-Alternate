using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

    /// <summary>
    /// Getter and setter for managing player's current life amount
    /// </summary>
    public int PlayerLife { get; set; }

    /// <summary>
    /// Getter and setter for managing player's current ammo
    /// </summary>
    public int ammoCount { get; set; }

    /// <summary>
    /// Getter and setter for determining if up button is held
    /// </summary>
    public bool UpHeld { get; set; }

    /// <summary>
    /// Getter and setter for determining if down button is held
    /// </summary>
    public bool DownHeld { get; set; }

    /// <summary>
    /// Getter and setter for determining if right strafe is held
    /// </summary>
    public bool rStrfHeld { get; set; }

    /// <summary>
    /// Getter and setter for determining if left strafe is held
    /// </summary>
    public bool lStrfHeld { get; set; }


    /// <summary>
    /// Called once at the start
    /// </summary>
    void Start()
    {
        //Set the player's initial life value appropriately
        PlayerLife = 100;

        //Set the player's ammo count 
        ammoCount = 6;

        //Set UpHeld, DownHeld, rStrfHeld, and lStrfHeld to false
        UpHeld = false;
        DownHeld = false;
        rStrfHeld = false;
        lStrfHeld = false;
    }
}
