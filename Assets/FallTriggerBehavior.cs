using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallTriggerBehavior : MonoBehaviour {

    public GameObject Player;
    public float yDifference = 50f;

    private PlayerControl playerControl;

    void Start() {        
        playerControl = Player.GetComponent<PlayerControl>();
    }

    void FixedUpdate() {
        Vector3 tempPosition = transform.position;
        tempPosition.x = Player.transform.position.x;
        if(playerControl.isGrounded) {
            tempPosition.y = Player.transform.position.y - yDifference;
        }
        transform.position = tempPosition;
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.CompareTag("Player")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
