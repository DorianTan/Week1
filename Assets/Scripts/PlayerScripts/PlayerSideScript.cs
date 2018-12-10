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
    private Collider2D swordCollider;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        swordCollider = GameObject.Find("Sword").GetComponent<Collider2D>();
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

        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }
        else
        {
            NoAttack();
        }

        if (_rigidbody2D.velocity != Vector2.zero)
        {
            playerAnimator.SetBool("isWalking", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }

        if (collision.gameObject.name == "Spike")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D swordCollider)
    {
        //TODO sword animation

        if (swordCollider.name == "Enemy")
        {
            Destroy(gameObject);
        }
    }

    void Attack()
    {
        swordCollider.enabled = true;
    }

    void NoAttack()
    {
        swordCollider.enabled = false;
        //TODO implement sword animation
    }
}