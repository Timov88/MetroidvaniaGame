using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    Transform player;
    SpriteRenderer sr;
    bool facingRight = false;
    [SerializeField] GameObject weapon;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void LookAtPlayer()
    {
        if (player.position.x > transform.position.x && !facingRight || player.position.x < transform.position.x && facingRight)
        {
            facingRight = !facingRight;
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }    
    }

    public void Attack(bool trueOrFalse)
    {
        weapon.SetActive(trueOrFalse);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

    }
}
