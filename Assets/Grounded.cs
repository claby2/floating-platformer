using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour {
    public GameObject Player;

    private PlayerControl playerControl;

    void Start() {
        playerControl = Player.GetComponent<PlayerControl>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.CompareTag("Ground")) {
            playerControl.isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if(collision.collider.CompareTag("Ground")) {
            playerControl.isGrounded = false;
        }
    }
}
