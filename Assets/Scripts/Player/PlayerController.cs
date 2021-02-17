using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
        Rigidbody2D rb;
        BoxCollider2D boxCollider2D;
        [SerializeField]float movementSpeed;
        [SerializeField]float jumpSpeed;
        [SerializeField]LayerMask platformLayerMask;
        private float horizontal;
        private float vertical;

        void Start() 
        {
            rb = GetComponent<Rigidbody2D>();
            boxCollider2D = GetComponent<BoxCollider2D>();
        }

        void FixedUpdate() 
        {
            IsGrounded();
            rb.velocity = new Vector2(horizontal*movementSpeed, rb.velocity.y);
            //If you change fixed update use Time.deltaTime so your movement speed is not gonna get cucked
            //rb.velocity = new Vector2(horizontal*movementSpeed*(Time.deltaTime*100), rb.velocity.y);
        }

       
        public void OnMoveInput(float horizontal, float vertical)
        {
            this.horizontal = horizontal;
            this.vertical = vertical;
            Debug.Log($"{horizontal},{vertical}");
        }

        public void OnJumpInput(bool jumpInput)
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
            //Debug.Log("KULLI Grounded");
            return hit.collider != null;
        }
}
