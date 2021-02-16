using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    PlayerInput playerInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();	
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        rb.velocity = new Vector2(playerInput.movement.x, rb.velocity.y);
    }
}
