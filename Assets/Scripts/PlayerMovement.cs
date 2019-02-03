using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float Speed;
	public float JumpForce;
	public float checkRadius;
	float moveInput;
	public Sprite Default;
	public Sprite JumpSprite;
	Rigidbody2D rb;
	bool facingRight = true;
	bool isGrounded;
	public Transform groundCheck;
	
	public LayerMask whatIsGround;

	Animator animator;
	SpriteRenderer sr;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		sr = GetComponent<SpriteRenderer>();
		
	}

	// Update is called once per frame
	void FixedUpdate () {

		isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

		moveInput = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(moveInput * Speed, rb.velocity.y);

		if (moveInput != 0 && isGrounded) 
		{
			animator.enabled = true;
		} else if (!isGrounded) {
			sr.sprite = JumpSprite;
			animator.enabled = false;
		} else {
			sr.sprite = Default;
			animator.enabled = false;
		}
		if (facingRight == false && moveInput > 0) {
			Flip();
		} else if (facingRight == true && moveInput < 0) {
			Flip();
		}
	}

	void Update() {
		if(Input.GetKey(KeyCode.UpArrow) && isGrounded) {
			rb.velocity = Vector2.up * JumpForce;
		}
	}

	void Flip () {
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;
	}
}
