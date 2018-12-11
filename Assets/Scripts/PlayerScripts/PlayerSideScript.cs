using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.PlayerLoop;

public class PlayerMovementSide : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerJumpforce;


    private float move = 0f;
    private Rigidbody2D _rigidbody2D;
    private bool isJumping = false;
    private bool keyPicked = false;

    public bool KeyPicked
    {
        get { return keyPicked; }
        set { keyPicked = value; }
    }
    private float horizontalInput;
    private SpriteRenderer playerSprite;
    private Animator playerAnimator;
    public Animator animator;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal") * playerSpeed;

        animator.SetFloat("Speed", Mathf.Abs(move));

        //_rigidbody2D.velocity = new Vector2(move * playerSpeed, _rigidbody2D.velocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            _rigidbody2D.AddForce(Vector2.up * playerJumpforce, ForceMode2D.Impulse);
            isJumping = true;
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

    private void OnTriggerEnter2D(Collider2D keyCollider)
    {
        if (keyCollider.gameObject.name == "Player")
        {
            keyPicked = true;
        }
    }
}