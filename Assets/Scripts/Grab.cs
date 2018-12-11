using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public Rigidbody2D rb;
    private DistanceJoint2D grabHinge;
    private float speed;
    private bool inAir = false;

    // Use this for initialization
    void Start()
    {
        grabHinge.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("fire2"))
        {
            GrapplingShot();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (inAir == true)
        {
            rb.velocity = Vector2.zero;
            inAir = false;
            grabHinge = gameObject.AddComponent<DistanceJoint2D>();
            grabHinge.connectedBody = collision.rigidbody;
        }
    }

    void GrapplingShot()
    {
        grabHinge.enabled = true;
        rb.velocity = new Vector2(0, transform.position.y) * speed;
        inAir = true;
    }
}