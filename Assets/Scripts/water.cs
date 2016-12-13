using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class water : MonoBehaviour {

    /// <summary>
    /// Game object's rigidbody component
    /// </summary>
    private Rigidbody rb;

    /// <summary>
    /// Float representing the max time till the player drowns
    /// </summary>
    private float drownTimer;

    /// <summary>
    /// Float representing the time the player has left
    /// </summary>
    private float currentTime;

    /// <summary>
    /// Text representing the drown countdown
    /// </summary>
    public Text countDown;

    /// <summary>
    /// The cube which will represent the underwater effect until the fog turns on
    /// </summary>
    public GameObject waterCube;

    /// <summary>
    /// The fire button object
    /// </summary>
    public GameObject fireButton;

    /// <summary>
    /// Called once at the start
    /// </summary>
    void Start ()
    {
        //Grab the rigidbody component
        rb = GetComponent<Rigidbody>();

        //Set currentTime appropriately
        currentTime = 30f;

        //Set the countdown timer display
        countDown.text = "";

        //Set the material of the water cube so that it is transparent and blue
        waterCube.GetComponent<MeshRenderer>().material.color = new Color(0.0f, 0.5f, 1.0f, 0.5f);
    }

	/// <summary>
    /// Called once per frame
    /// </summary>
	void Update () {

        //Increase the water level
        rb.AddForce(0,.0002f,0);

        //Check if the water cube has been destroyed
        //If not, raise it along with the water surface
        if (waterCube != null)
        {
            waterCube.GetComponent<Rigidbody>().AddForce(0, .0002f, 0);
        }


        //If the water rises above the gun,
        //disable the ability to fire
        if(transform.position.y >= 1.3)
        {
            fireButton.GetComponent<Button>().interactable = false;
        }

        //If the water rises above the camera
        //Set the renderer's fog and start the countdown
        if (transform.position.y >= 1.8)
        {
            Destroy(waterCube);
            RenderSettings.fogColor = new Color(0.0f, 0.5f, 1.0f);
            RenderSettings.fogDensity = 0.15F;

            countDown.text = "Time till Drowning: " + currentTime;
            currentTime -= Time.deltaTime;

            //Check if Time.deltaTime is greater than or equal
            //to drownTimer
            if (currentTime <= 0)
            {
                //Load the game over screen
                SceneManager.LoadScene(1);
            }
        }
      
	}
}
