using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final_nodeAppear : MonoBehaviour
{


    
    warp_escape warpEscape;
    enemy_shooter enemyShooter;
    public Renderer rend;



   
    void Start()
    {
     
       enemyShooter = FindObjectOfType<enemy_shooter>();
        rend = GetComponent<Renderer>();
         rend.enabled = false;
    }

    
    public void acitivateFinalNode() 
    {    
        rend.enabled = true;
      
    
   }

   public void OnTriggerEnter2D(Collider2D other)
    {
        enemyShooter = FindObjectOfType<enemy_shooter>();
        enemyShooter.destroyBoss();

        warpEscape = FindObjectOfType<warp_escape>();
        warpEscape.acitivateWarpEscape();




    }


}
