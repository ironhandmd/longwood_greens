using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ant : MonoBehaviour
{
    guide_Controller guideController;
    antGate Antgate;
    public bool fruitTaken=false;

    void Start() 
    {

        fruitTaken = false;
    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (tag == "ant")
        {
            if (fruitTaken == false)
            {

                guideController = FindObjectOfType<guide_Controller>();
                guideController.activateantDig1();

            }
            else
            {
                
                guideController.activateantDig2();
                openAntGate();


            }

        }
    
    }


    private void OnTriggerExit2D(Collider2D other) 
    {
        if (tag == "ant")
        {
            if (fruitTaken == false)
            {
                guideController.deactivateantDig1();

            }
            else 
            {

                guideController.deactivateantDig2();
            
            }
        }
    }


   
    
    

   
    
     
    
    
    
    

    public void openAntGate() 
    {
        Antgate = FindObjectOfType<antGate>();
        Antgate.gotFruit();
       
    
    
    }
    public void fruitIsTaken() 
    {
        fruitTaken = true;
     


        }
    
    }
    



