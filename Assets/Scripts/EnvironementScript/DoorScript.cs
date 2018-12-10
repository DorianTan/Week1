using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D doorCollider)
    {  
        if (doorCollider.gameObject.name == "Player")
        {
            SceneManager.LoadScene(3);
            Debug.Log("Scene loaded");
        }
    }
}