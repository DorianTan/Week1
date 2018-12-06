using UnityEngine;
using System.Collections;

public class PlayerMovementSide : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerJumpforce;

    private Rigidbody2D _rigidbody2D;
    private bool isJumping = false;
    private float horizontalInput;


    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float move = Input.GetAxis("Horizontal");

        _rigidbody2D.velocity = new Vector2(move * playerSpeed, _rigidbody2D.velocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            _rigidbody2D.AddForce(Vector2.up * playerJumpforce, ForceMode2D.Impulse);
            isJumping = true;
            Debug.Log(isJumping);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }
}