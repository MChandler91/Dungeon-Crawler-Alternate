using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {

    /// <summary>
    /// Called when a trigger object collides with another object
    /// </summary>
    /// <param name="col"></param>
    void OnTriggerEnter(Collider col)
    {
        //If the colliding object has the tag "wall"
        //destroy the bullet game object
        if (col.CompareTag("wall"))
        {
            Destroy(gameObject);
        }

    }

}
