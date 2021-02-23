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
    Animator anim;
    
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponentInChildren<Animator>();
        
    }

    public void LookAtPlayer()
    {
        
        if ((player.position.x > transform.position.x && !facingRight || player.position.x < transform.position.x && facingRight) && (transform != null))
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
    public void EnemyStunned()
    {
        //anim.SetTrigger("Stun");
        anim.SetBool("Stunned", true);
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        
        //GetComponent<Collider2D>().enabled = false;
        StartCoroutine(WaitStunEnd());
    }

    public IEnumerator WaitStunEnd()
    {
        // enemy = GetComponent<Enemy>();
        Debug.Log("vihollinen on stunnissa, lol");
        
        yield return new WaitForSeconds(4);
        rb.constraints = RigidbodyConstraints2D.None;
        anim.SetBool("Stunned", false);

    }
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

    }
}
