using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unolck_strength : MonoBehaviour
{
    player_movement playerMovement;
    
    private void OnCollisionEnter2D(Collision2D collider) 
    {

        unlockAbility(); 
    
    }

    private void unlockAbility() 
    {

        playerMovement = FindObjectOfType<player_movement>();
        playerMovement.unlockStrength();
        removeItem();
    
    }

    private void removeItem() 
    {

        Destroy(gameObject);
    
    }

}
