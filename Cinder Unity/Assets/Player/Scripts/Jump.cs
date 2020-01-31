using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Jump : MonoBehaviour
{

    //[Range(1, 10)]
    public float jumpVelocity = 5;
    [Range(1,5)]
    public float fallMultiplier = 2.5f;
    [Range(1,5)]
    public float lowJumpMultiplier = 2f;

    public float maxFallVelocity = 5;

    public int extraJumpValue = 1;

    private int extraJumps;

    Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private bool jumpInput;
    private bool jumpHold;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpInput = false;
        jumpHold = false;
        extraJumps = extraJumpValue;
    }
    void Update()
    {
        
        jumpInput = Input.GetButtonDown("Jump");
        jumpHold = Input.GetButton("Jump");
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        if (isGrounded)
        {
            extraJumps = extraJumpValue;
        }

        jump();
    }
    void FixedUpdate()
    {
        if(rb.velocity.y < -maxFallVelocity)
        {
            Vector2 v = new Vector2(rb.velocity.x,-maxFallVelocity);
            rb.velocity = v;
        }
    }

    private void jump()
    {
        
        if (jumpInput && isGrounded)
        {
            rb.velocity = getJumpVector();
        }

        else if (jumpInput && extraJumps > 0)
        {
            rb.velocity = getJumpVector();
            extraJumps--;
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !jumpHold)
        {
            rb.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    private Vector2 getJumpVector()
    {
        Vector2 jump = Vector2.up * jumpVelocity;
        jump.x = rb.velocity.x;
        return jump;
    }
}
