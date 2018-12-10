using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rig;
    [SerializeField] private float speed;
    [SerializeField] private float posMax;
    [SerializeField] private float posMin;
    public float health;

    enum Enemy
    {
        GO_LEFT,
        GO_RIGHT,
        //DIE,
    }
    private Enemy enemy;

    void Start()
    {
        enemy = Enemy.GO_LEFT;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
    }

    void Update()
    {
        switch (enemy)
        {
            case Enemy.GO_LEFT:
                GoLeft();
                break;
            case Enemy.GO_RIGHT:
                GoRight();
                break;
            //case Enemy.DIE:

            //    break;
        }
    }

    public void GoLeft()
    {       
        if (gameObject.transform.position.x>=posMax)
        {
            enemy = Enemy.GO_RIGHT;
        }
            rig.velocity=new Vector2(speed,0);

    }

    public void GoRight()
    {
        if (gameObject.transform.position.x <= posMin)
        {
            enemy = Enemy.GO_LEFT;
        }
        rig.velocity = new Vector2(-speed,0);
    }

    public void OnTriggerEnter2D(Collider2D Player)
    {
        GameManager.lives -= 1;
    }

}
