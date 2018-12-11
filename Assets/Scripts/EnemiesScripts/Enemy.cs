using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (health <= 0)
	    {
	        Destroy(gameObject);
	    }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }


    public void OnTriggerEnter2D(Collider2D col)
    {
        GameManager.lives -= 1;
    }
}
