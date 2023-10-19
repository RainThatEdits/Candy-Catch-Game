//collectible script make sure to set "is trigger" and "player" tag

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) //take out the 2D for 3D versions
    {
      
        if (other.transform.tag == "Player")
        {
            
            Destroy(gameObject);
            Debug.Log("you scored");
        }
        if (other.transform.tag == "edge")
        {
            Destroy(gameObject);
            Debug.Log("you missed");
        } 
    
    
    
    
    }
}