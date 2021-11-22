using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acid_protect : MonoBehaviour
{

    acid_pool acidPool;

   

     private void OnCollisionEnter2D(Collision2D collider)
    {

        disableAcid();
        removeItem();
    }

    public void disableAcid() 
   {
        acidPool = FindObjectOfType<acid_pool>();
        acidPool.nullifyAcid();
    
    }
  

    private void removeItem()
    {





        Destroy(gameObject);

    }






}
