using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateCameraX : MonoBehaviour
{
    private float speed = 200;
    public GameObject player;
    public float horizontalInput;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, horizontalInput * speed * Time.deltaTime);

        transform.position = player.transform.position; // Move focal point with player

    }

    void OnMove(InputValue movementValue)
    {
        horizontalInput = movementValue.Get<Vector2>().x;
    }
}