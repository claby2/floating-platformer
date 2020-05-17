using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public Rigidbody2D rb;
    public float moveSpeed = 10f;
    public float jumpHeight = 20f;
    public bool isGrounded = false;
    public float horizontalMove;
    public bool jump = false;

    private float jumpRemember;
    private const float jumpRememberTime = 0.2f;


    void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if(jumpRemember >= 0) {
            jumpRemember -= Time.deltaTime;
        }
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))) {
            jumpRemember = jumpRememberTime;
        }

        if ((jumpRemember > 0) && isGrounded) {
            jumpRemember = 0;
            jump = true;
        }
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
        if(jump) {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            jump = false;
        }
    }
}
