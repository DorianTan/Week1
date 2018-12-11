using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rig;
    [SerializeField] private float speed;
    [SerializeField] private float posMax;
    [SerializeField] private float posMin;
    public static int health=20;

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
        }
        if (health<=0)
        {
            Destroy(gameObject);   
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

    private void OnCollisionEnter2D(Collision2D player)
    {
        if (player.gameObject.name == "Player")
        {
            Debug.Log("sa touche");
            GameManager.lives -= 1;
        }   
    }
}
