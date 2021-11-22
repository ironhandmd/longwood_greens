using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class warp_escape : MonoBehaviour
{   
    scene_management SceneManagement;
    public Renderer rend;
    public Collider2D col;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
        col = GetComponent<Collider2D>();
        col.enabled = false;
    }   

    public void acitivateWarpEscape()
    {
        rend.enabled = true;
        col.enabled = true;

    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        SceneManagement = FindObjectOfType<scene_management>();
        SceneManagement.EndingScene();
    
    }



}
