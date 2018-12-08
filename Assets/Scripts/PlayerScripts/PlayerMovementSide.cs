using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.PlayerLoop;

public class PlayerMovementSide : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerJumpforce;

    private Rigidbody2D _rigidbody2D;
    private bool isJumping = false;
    private float horizontalInput;
    private SpriteRenderer playerSprite;
    private Animator playerAnimator;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        _rigidbody2D.velocity = new Vector2(move * playerSpeed, _rigidbody2D.velocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            _rigidbody2D.AddForce(Vector2.up * playerJumpforce, ForceMode2D.Impulse);
            isJumping = true;
        }

        if (_rigidbody2D.velocity != Vector2.zero)
        {
            playerAnimator.SetBool("isWalking", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isJumping = false;
        }

        if (collision.gameObject.name == "Spike")
        {
            Destroy(gameObject);
        }
    }
}