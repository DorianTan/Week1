using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.PlayerLoop;

public class PlayerSideScript : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerJumpforce;

    

    private Rigidbody2D _rigidbody2D;
    private bool isJumping = false;
    private float horizontalMove;
    private SpriteRenderer playerSprite;
    public Animator playerAnimator;
    private float move = 0f;
    private bool facingRight;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");
        _rigidbody2D.velocity = new Vector2(move * playerSpeed, _rigidbody2D.velocity.y);
        playerAnimator.SetFloat("Move_Right", move);
        //playerAnimator.SetFloat("Move_Left", move);

        if (move < 0)
        {
            facingRight = false;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            facingRight = true;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }


        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            _rigidbody2D.AddForce(Vector2.up * playerJumpforce, ForceMode2D.Impulse);
            isJumping = true;
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
            GameManager.lives -= 1;
        }
    }


}