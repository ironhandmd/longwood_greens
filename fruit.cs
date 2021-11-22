using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour
{
    ant Ants;

    
    private void OnCollisionEnter2D(Collision2D collider) 
    {



        disableAntGate(); 
        destroyCherry();

        

    }

    void destroyCherry() 
    {
        Destroy(gameObject);
    
    }

     public void disableAntGate()
  {
      Ants = FindObjectOfType<ant>();
      Ants.fruitIsTaken();
  
  
  }

}