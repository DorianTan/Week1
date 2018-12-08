using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    [SerializeField] private GameObject SwordPrefab;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetMouseButton(0))
	    {
	            SwordPrefab.GetComponent<Sword>().damages = damage;
        }
	}
}
