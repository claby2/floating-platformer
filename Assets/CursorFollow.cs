using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorFollow : MonoBehaviour {
    public Camera MainCamera;

    void Start() {
        Cursor.visible = false;
    }

    void Update() {
        Vector2 cursorPos = MainCamera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
    }
}
