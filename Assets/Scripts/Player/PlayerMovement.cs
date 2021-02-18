using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    PlayerInput playerInput;
    BoxCollider2D boxCollider2D;
    [SerializeField]float movementSpeed;
    [SerializeField]float jumpSpeed;
    [SerializeField]LayerMask platformLayerMask;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
        boxCollider2D = GetComponent<BoxCollider2D>(); 
    }

    void Update()
    {
        IsGrounded();
    }

    public void Movement(Vector2 asd)
    {
        rb.velocity = new Vector2(playerInput.movement.x*movementSpeed, rb.velocity.y);
        //Debug.Log(playerInput.movement.x);
    }

    public void MoveKeyboard()
    {
        
    }

    public void Jump()
    {
        if (IsGrounded())
        {
            rb.AddForce(Vector2.up*jumpSpeed, ForceMode2D.Impulse);
        }
    }



    private bool IsGrounded() 
    {
       RaycastHit2D hit = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.05f, platformLayerMask);
       //Debug.DrawRay(boxCollider2D.bounds.center, Vector2.down * (boxCollider2D.bounds.extents.y + 0.05f), Color.red);
       return hit.collider != null;
    }
}
