using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock_speed : MonoBehaviour
{

    speed_controller speedController;

    

    private void OnCollisionEnter2D(Collision2D collider)
    {

        speedController = FindObjectOfType<speed_controller>();
        speedController.unlockSpeedAbility();
        removeItem();
    }

    

    private void removeItem()
    {

        Destroy(gameObject);

    }




}
