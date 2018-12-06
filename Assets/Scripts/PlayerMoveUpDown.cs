using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveUpDown : MonoBehaviour
{

    [SerializeField]
    private float speed;
    private Rigidbody2D rigid;


    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
 

    void Move()
    {
        Vector2 velocity = new Vector2(Input.GetAxis("Horizontal") * speed*Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        rigid.velocity = velocity;
    }

    public void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {

        }
    }
}
