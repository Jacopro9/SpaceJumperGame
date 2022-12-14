using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 7f;
    [SerializeField] public float jumpForce = 14f;
    [SerializeField] private LayerMask jumpableGround;

    public Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    private void OnEnable()
    {
        HealthController.OnPlayerDeath += DisablePlayerMovement;
    }

    private void OnDisable()
    {
        HealthController.OnPlayerDeath -= DisablePlayerMovement;
    }

    private float dirX = 0f;
    private enum MovementState { idle, running, jumping, falling }

  

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        EnablePlayerMovement();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        MovementState state;

        if (dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if (rb.velocity.y > 0.01f)
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -0.01f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, jumpableGround);
    }

    private void DisablePlayerMovement() 
    {
        anim.enabled = false;
        rb.bodyType = RigidbodyType2D.Static;
    }

    private void EnablePlayerMovement() 
    {
        anim.enabled = true;
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Powerup");
        {
            StartCoroutine(ResetPower());
            //GetComponent<SpriteRenderer>().color = Color.blue;
        }
      
    }
    private IEnumerator ResetPower()
    {
        yield return new WaitForSeconds(10);
        jumpForce = 10;
        moveSpeed = 7;
    }
}

    
        
    

 