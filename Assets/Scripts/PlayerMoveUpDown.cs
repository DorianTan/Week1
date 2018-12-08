using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveUpDown : MonoBehaviour
{

    [SerializeField]
    private float speed;
    private Rigidbody2D rigid;

    public Animator animator;


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
        animator.SetFloat("Horizontal",velocity.x);
        animator.SetFloat("Vertical", velocity.y);
        animator.SetFloat("Magnitude",velocity.magnitude);

    }

    public void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {

        }
    }
}
