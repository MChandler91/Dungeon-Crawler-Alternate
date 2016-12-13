using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fireBtn : MonoBehaviour {

    /// <summary>
    /// Bullet game object prefab
    /// </summary>
    public GameObject bullet;

    /// <summary>
    /// The spawn node for the bullets
    /// </summary>
    public Transform bSpawn;

    /// <summary>
    /// gameManager script component
    /// </summary>
    public gameManager gm;

    /// <summary>
    /// Text for fire button
    /// </summary>
    public Text btnText;

    /// <summary>
    /// Explosion game object prefab
    /// </summary>
    public GameObject explosion;

    /// <summary>
    /// The spawn node for the explosion
    /// </summary>
    public Transform expSpawn;

    /// <summary>
    /// Game object to hold instantiated prefab of bullets
    /// </summary>
    private GameObject b;

    /// <summary>
    /// Game object to hold instantiated prefab of explosions
    /// </summary>
    private GameObject expl;

    /// <summary>
    /// The audio source component
    /// </summary>
    private AudioSource audioSrc;

    /// <summary>
    /// Called once at the start
    /// </summary>
    void Start()
    {
        //Set fire button text appropriately
        btnText.text = "Fire!";

        //Grab the gameManager script component from the Game Manager object
        gm = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<gameManager>();

        //Grab the audio source component
        audioSrc = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Called when player presses the fire button
    /// </summary>
    public void fire()
    {
        //Check if the player has ammo
        if (gm.ammoCount > 0)
        {
            //Play the audio source clip
            audioSrc.Play();

            //Set b to an instantiation of the bullet prefab, at the position of the bulletspawn
            b = (GameObject)Instantiate(bullet, bSpawn.position, bSpawn.rotation);

            //Set expl to an instantiation of the explosion prefab, at the position of expSpawn
            expl = (GameObject)Instantiate(explosion, expSpawn.position, expSpawn.rotation);

            //Set b's velocity so that it moves forward at a given speed
            b.GetComponent<Rigidbody>().velocity = bSpawn.transform.forward * 100;

            //Destroy b if it travels too far
            Destroy(b, 2.0f);

            //Destroy expl after a small amount of time 
            Destroy(expl, .5f);

            //Decrement the ammo count
            gm.ammoCount--;
        }
    }

}
