using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern : MonoBehaviour
{
    [SerializeField] private float enemySpeed;

    public float minDist = 30.0f;
    public float maxDist = 30.0f;
    private Vector2 initialPosition;
    int direction = -1;


    // Use this for initialization
    void Start()
    {
        initialPosition = transform.position;
        direction = -1;
        maxDist += transform.position.x;
        minDist -= transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        switch (direction)
        {
            case -1:
                // Moving Left
                if (transform.position.x > minDist)
                {
                    GetComponent<Rigidbody2D>().velocity =
                        new Vector2(-enemySpeed, GetComponent<Rigidbody2D>().velocity.y);
                }

                else
                {
                    direction = 1;
                }

                break;

            case 1:
                //Moving Right
                if (transform.position.x < maxDist)
                {
                    GetComponent<Rigidbody2D>().velocity =
                        new Vector2(enemySpeed, GetComponent<Rigidbody2D>().velocity.y);
                }

                else
                {
                    direction = -1;
                }

                break;
        }
    }

}