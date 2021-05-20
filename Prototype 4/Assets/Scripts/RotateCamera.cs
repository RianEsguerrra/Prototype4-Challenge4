using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateCamera : MonoBehaviour
{
    private float speed = 20;
    public float rotationSpeed;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }

    void OnMove(InputValue movementValue)
    {
        horizontalInput = movementValue.Get<Vector2>().x;
    }
}