using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {
    public GameObject Player;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    private PlayerControl playerControl;
    private Rigidbody2D playerRb;
    private bool isMoveStopped = false;

    void Start() {
        playerControl = Player.GetComponent<PlayerControl>();
        playerRb = Player.GetComponent<Rigidbody2D>();
    }

    void Update() {
        animator.SetFloat("horizontal", Mathf.Abs(playerRb.velocity.x));
        animator.SetBool("isJump", playerRb.velocity.y > 0.01);
        animator.SetBool("isMoveStopped", isMoveStopped);

        if((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))) {
            isMoveStopped = true;
        }

        if(playerControl.horizontalMove < 0) {
            spriteRenderer.flipX = true;
        } else if(playerControl.horizontalMove > 0) {
            spriteRenderer.flipX = false;
        }
    }

    public void SetMoveStoppedNegative() {
        isMoveStopped = false;
    }
}
