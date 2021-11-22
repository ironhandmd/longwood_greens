using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toBossWarp : MonoBehaviour
{
    scene_management SceneManagement;
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManagement = FindObjectOfType<scene_management>();
        SceneManagement.goToBoss();

    }


}
