using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class story_panel_controller : MonoBehaviour
{

    public GameObject storyPanel1;
    public GameObject storyPanel2;
    public GameObject storyPanel3;
    



 public void onPanel1()
 {
     storyPanel1.SetActive(true);
     storyPanel2.SetActive(false);
     storyPanel3.SetActive(false);

 
 
 }
 public void onPanel2() 
 {

     storyPanel1.SetActive(false);
     storyPanel2.SetActive(true);
     storyPanel3.SetActive(false);
 }
 public void onPanel3() 
 {
     storyPanel1.SetActive(false);
     storyPanel2.SetActive(false);
     storyPanel3.SetActive(true);
 
 
 
 
 }

 public void backtoMenu() 
 {

     storyPanel1.SetActive(false);
     storyPanel2.SetActive(false);
     storyPanel3.SetActive(false);
 
 
 }
 
}
