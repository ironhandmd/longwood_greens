using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed_controller : MonoBehaviour
{
    player_movement playerMovement;

    public void unlockSpeedAbility()
    {

        var s = GetComponent<speed_controller>().enabled = true;


    }
    
    void Update()
     {

         if (Input.GetKey(KeyCode.P))
         {
             playerMovement = FindObjectOfType<player_movement>();
             playerMovement.unlockSpeed();

         }
         else 
         {
             playerMovement = FindObjectOfType<player_movement>();
             playerMovement.sameSpeed();
         
         }

     }
}
