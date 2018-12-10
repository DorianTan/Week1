using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int damage;
    public GameObject sword;

    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetMouseButtonDown(0))
	    {
	        sword.SetActive(true);
	    }
	    if (Input.GetMouseButtonUp(0))
	    {
	        sword.SetActive(false);
	    }
    }

    public void Toggle() // marche pour le bouton "continue"
    {
        Debug.Log("attack");

        sword.SetActive(!sword.activeSelf); //plus simple pour basculer d'un état à l'autre
    }
}
