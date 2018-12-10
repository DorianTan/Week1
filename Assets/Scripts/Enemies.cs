﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rig;
    [SerializeField] private float speed;
<<<<<<< HEAD
    [SerializeField] private float posMax;
    [SerializeField] private float posMin;
    public float health;
    

=======
    [SerializeField] private float posMax = 3.5f;
    [SerializeField] private float posMin = -1f;
>>>>>>> Ethan

    private bool call1=true;
    enum Enemy
    {
        GO_UP,
        GO_DOWN,
        DIE,
    }
    private Enemy enemy;

    void Start()
    {
        enemy = Enemy.GO_UP;
    }

<<<<<<< HEAD
    public void TakeDamage(float amount)
    {
        health -= amount;
    }

=======
>>>>>>> Ethan

    void Update()
    {
        switch (enemy)
        {
            case Enemy.GO_UP:
                GoUp();
                break;
            case Enemy.GO_DOWN:
                GoDown();
                break;
            case Enemy.DIE:

                break;
        }
    }

    public void GoUp()
    {       
        if (gameObject.transform.position.y>=posMax)
        {
            enemy = Enemy.GO_DOWN;
        }
            rig.velocity=new Vector2(0,speed);

    }

    public void GoDown()
    {
        if (gameObject.transform.position.y <= posMin)
        {
            enemy = Enemy.GO_UP;
        }
        rig.velocity = new Vector2(0, -speed);
    }

    public void OnTriggerEnter2D(Collider2D Player)
    {
        GameManager.lives -= 1;
    }

}
