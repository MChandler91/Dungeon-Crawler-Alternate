using UnityEngine;
using System.Collections;

public class monsterMove : MonoBehaviour {

    /// <summary>
    /// Enemy's current life
    /// </summary>
    private int enemyLife;

    /// <summary>
    /// gameManager script
    /// </summary>
    private gameManager gm;

    /// <summary>
    /// Enemy's rigidbody component
    /// </summary>
    private Rigidbody rb;

	/// <summary>
    /// Called once at the start
    /// </summary>
	void Start () {
        
        //Set the enemy's life appropriately
        enemyLife = 100;

        //Grab the gameManager script component by locating the Game Manager object
        gm = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<gameManager>();

        //Grab the rigidbody component
        rb = GetComponent<Rigidbody>();
       
	}
	
    /// <summary>
    /// Called when a trigger object collides with the enemy game object
    /// </summary>
    /// <param name="col"></param>
    void OnTriggerEnter(Collider col)
    {
        //If the trigger object has the tag 'bullet
        //Subtract 25 points from the enemy's life
        if (col.CompareTag("bullet"))
        {
            enemyLife -= 50;
        }

        //If the trigger object has the tag 'coin'
        //rotate the enemy object
        if (col.CompareTag("coin"))
        {
            transform.Rotate(0, 180, 0);
        }
    }

    /// <summary>
    /// Called when there is a collision with a non-trigger object
    /// </summary>
    /// <param name="col"></param>
    void OnCollisionEnter(Collision col)
    {
        //If the object collided with has the tag 'wall'
        //Rotate the enemy game object
        if (col.gameObject.CompareTag("wall"))
        {
            transform.Rotate(0, 180, 0);
        }

        //If the object collided with has the tag 'monster'
        //Rotate the enemy game object
        if (col.gameObject.CompareTag("monster"))
        {
            transform.Rotate(0, 180, 0);
        }

        //If the object collided with has the tag 'player'
        //Play an attack animation and subtract a damage amount
        //from the player's life amount in the gameManager script
        if (col.gameObject.CompareTag("player"))
        {
            rb.velocity = Vector3.zero;
            GetComponent<Animation>().Play("creature1Attack1");
            Debug.Log("Collided with player!");
            gm.PlayerLife -= 100;
            Debug.Log(gm.PlayerLife);
        }
    }


    /// <summary>
    /// Called once every fixed framerate frame
    /// </summary>
    void FixedUpdate () {

        //If the enemy's life drops to or below zero
        //Destroy the enemy game object
        if(enemyLife <= 0)
        {
            Destroy(gameObject);
        }

      
       //Add a forward force to move the enemy object
       rb.AddForce(transform.forward * 25);

        //If the magnitude of the rigidbody's velocity is greater than zero, and the attack animation is not playing
        if (rb.velocity.magnitude > 0 && GetComponent<Animation>().IsPlaying("creature1Attack1") == false)
        {
            //Play the walking animation
            GetComponent<Animation>().Play("creature1walkforward");
        }

    }
}
