using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;

    public GameObject heart1, heart2, heart3;

	// Use this for initialization
	void Start ()
	{
		heart1.gameObject.SetActive(true);
	    heart2.gameObject.SetActive(true);
	    heart3.gameObject.SetActive(true);
    }
	
	// Update is called once per frame
	void Update ()
	{
	    switch (lives)
	    {
            case 2:
                heart1.gameObject.SetActive(false);
                break;
	        case 1:
	            heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
	            break;
	        case 0:
	            heart1.gameObject.SetActive(true);
	            heart2.gameObject.SetActive(true);
	            heart3.gameObject.SetActive(true);
                SceneManager.LoadScene("Scenes/MainMenu");
	            lives = 3;
                break;
        }
	}
}
