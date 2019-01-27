using UnityEngine;
using System.Collections;

public class Mainplayer : MonoBehaviour {
    
    public float moveSpeed;
    public float jumpHeight;
    private bool isRight;

    public KeyCode space;
    public KeyCode right;
    public KeyCode left;

    public Transform GroundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool isGrounded;

    private Animator animation;

    public bool canMove;
	public AudioSource walkSound;
	public AudioSource jumpSound;
	public AudioSource hitSound;
	public AudioSource attackSound;
	public float walkCounter = 0;

    void flip()
    {
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }

     // Use this for initialization
    void Start()
    {
        isRight = true;
        animation = GetComponent<Animator>();
        canMove = true;
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(left))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            if (isRight)
            {
                flip();
                isRight = false;
            }
			if (walkCounter == 10)
			{
				walkSound.Play();
				walkCounter = 0;
			}
			else
				walkCounter++;
        }
        if (Input.GetKey(right))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            if (!isRight)
            {
                flip();
                isRight = true;
            }
			if (walkCounter == 10)
			{
				walkSound.Play();
				walkCounter = 0;
			}
			else
				walkCounter++;
        }
        if (Input.GetKeyDown(space) && isGrounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
			jumpSound.Play();
        }
        animation.SetFloat("MoveSpeed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        animation.SetBool("IsGrounded", isGrounded);


        if (!canMove)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        }
    }


}
