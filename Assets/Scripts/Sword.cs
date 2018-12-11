﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

    [SerializeField] private int damage=10;


    private void OnTriggerEnter2D(Collider2D col)
    {    
        if (col.gameObject.tag == "Enemy")
        {
            Enemies.health -= damage;
        }
    }
}
