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
        [SerializeField]AudioSource jumpAudio;
        private float horizontal;
        private float vertical;
        bool facingRight = false; 

        void Start() 
        {
            rb = GetComponent<Rigidbody2D>();
            boxCollider2D = GetComponent<BoxCollider2D>();

            //facingRight = !facingRight;
           // transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
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

           if(horizontal < 0 && !facingRight || horizontal > 0 && facingRight)
           {
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
                facingRight = !facingRight;
           }
            Debug.Log($"{horizontal},{vertical}");
        }

        public void OnJumpInput(bool jumpInput)
        {
            if (IsGrounded())
            {
                Debug.Log("SOITA AUDIO");
                //jumpAudio.Play();
                rb.AddForce(Vector2.up*jumpSpeed, ForceMode2D.Impulse);
            }
        }

        private bool IsGrounded() 
        {
            RaycastHit2D hit = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.05f, platformLayerMask);
            return hit.collider != null;
        }
}
