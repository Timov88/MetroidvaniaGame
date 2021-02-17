using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
        Rigidbody2D rb;
        [SerializeField]float movementSpeed;
        private float horizontal;
        private float vertical;

        void Start() 
        {
            rb = GetComponent<Rigidbody2D>();   
        }

        void FixedUpdate() 
        {
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
}
