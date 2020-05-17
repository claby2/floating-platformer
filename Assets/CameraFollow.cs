using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject Player;

    void FixedUpdate() {
        Vector3 tempPosition = transform.position;
        tempPosition.x = Player.transform.position.x;
        tempPosition.y = Player.transform.position.y;
        transform.position = tempPosition;
    }
}
