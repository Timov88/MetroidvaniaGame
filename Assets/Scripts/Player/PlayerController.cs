using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D boxCollider2D;
    DashTrail dashTrail;
    [SerializeField]float movementSpeed;
    [SerializeField]float jumpSpeed;
    [SerializeField]float dashSpeed;
    [SerializeField]float dashTime;
    [SerializeField]LayerMask platformLayerMask;
    [SerializeField]LayerMask LadderLayer;
    [SerializeField]AudioSource jumpAudio;
    [SerializeField]float dashcd;
    private float horizontal;
    private float vertical;
    bool facingRight = false;
    bool dashing = false;
    bool melee = false;
    private GameObject gun;
    Animator anim;
    IEnumerator dash;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayerMask;
    bool knockback = false;
    bool dashasd = true;
    public Vector2 knockbackDirection;
   // HitPoints playerDeath;



    void Start() 
    {
            rb = GetComponent<Rigidbody2D>();
            boxCollider2D = GetComponent<BoxCollider2D>();
            anim = GetComponent<Animator>();
            dashTrail = GetComponent<DashTrail>();    
            
    }

    void FixedUpdate() 
    {
        //IsGrounded();
        if (!dashing && !knockback)
        {
            rb.velocity = new Vector2(horizontal*movementSpeed, rb.velocity.y);
            anim.SetFloat("Run", Mathf.Abs(horizontal));
            //anim.speed = Mathf.Abs(horizontal);
        }
        //Hyppyanimaation alkuosan tarkistus/suunta
        anim.SetFloat("Velocity", rb.velocity.y);
        
        if (IsGrounded())
        {
            anim.SetBool("Jump", false);
        }
        
        //If you change fixed update use Time.deltaTime so your movement speed is not gonna get cucked
        //rb.velocity = new Vector2(horizontal*movementSpeed*(Time.deltaTime*100), rb.velocity.y);   
        if(IsClimbing())
        {
            rb.gravityScale = 0;
            anim.SetBool("Climb", true);
           // rb.velocity = new Vector2 (0, vertical * movementSpeed);
            rb.transform.position += (Vector3.up * Mathf.Round(vertical)) * movementSpeed * Time.fixedDeltaTime;
            //rb.velocity = new Vector2(rb.velocity.x, vertical * movementSpeed);
            

        }
        //else if (vertical < 0 && IsClimbing())
        //{
        //    rb.gravityScale = 0;
        //    anim.SetBool("Climb", true);
        //   // rb.velocity = new Vector2(0, vertical * movementSpeed);
        //    rb.transform.position += Vector3.down * movementSpeed * Time.fixedDeltaTime;
        //}

        //if (IsClimbing())
        //{
        //    rb.gravityScale = 0;
        //}
            if (!IsClimbing())
        {
            rb.gravityScale = 1;
            anim.SetBool("Climb", false);
        }
    }

   

    public void OnMoveInput(float horizontal, float vertical)
    {

        if (!dashing && !knockback)
        {
            this.horizontal = horizontal;
            this.vertical = vertical;
            if (horizontal < 0 && !facingRight || horizontal > 0 && facingRight)
            {
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
                Transform gun = transform.Find("Gun");
                gun.Rotate(0f, 180f, 0f);
                facingRight = !facingRight;
            }
            //Debug.Log($"{horizontal},{vertical}");
        }
    }

    public void OnJumpInput(bool jumpInput)
    {
        if (IsGrounded())
        {   
           // Debug.Log("SOITA AUDIO");
            //jumpAudio.Play();//
            rb.AddForce(Vector2.up*jumpSpeed, ForceMode2D.Impulse);
            anim.SetBool("Jump", true);
            
        }
        
    }

    public void OnDashInput(bool dashInput)
    {
        if (!dashing && dashasd)
        {
            dash = Dash();
            StartCoroutine(dash);
            StartCoroutine(CD());
        }
    }
    private bool IsClimbing()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.01f, LadderLayer);
        return hit.collider != null;

    }
    private bool IsGrounded() 
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.05f, platformLayerMask);
        return hit.collider != null;
    }
   
    IEnumerator Dash()
    {
        dashing = true;
        rb.velocity = new Vector2(transform.localScale.x*dashSpeed, rb.velocity.y);
        dashTrail.InvokeRepeating("SpawnTrailPart",0,0.03f);
        yield return new WaitForSeconds(dashTime);
        dashTrail.CancelInvoke("SpawnTrailPart");
        dashing = false;
    }
    public IEnumerator KnockBack()
    {
        Debug.Log("testi������");
        knockback = true;
        //this.vertical = 0;
        /*movementSpeed = 0;
        Debug.Log($"{horizontal},{vertical}");
        Debug.Log(movementSpeed);*/
        //yield return new WaitForSeconds(0.1f);
        //Mathf.Clamp(rb.position - knockbackDirection, -1, 1);
        //Quaternion.LookRotation(knockbackDirection);
        //Debug.Log(knockbackDirection.)
        //rb.AddRelativeForce((rb.position.normalized - knockbackDirection.normalized)*0.2f, ForceMode2D.Impulse);
        rb.velocity = new Vector2(Mathf.Clamp(rb.position.x - knockbackDirection.x, -1, 1) * 5.0f, rb.velocity.y);
        //rb.velocity = new Vector2(0.2f, rb.velocity.y);
        Debug.Log(new Vector2(Mathf.Clamp(rb.position.x - knockbackDirection.x, -1, 1) * 5.0f, rb.velocity.y));
        yield return new WaitForSeconds(0.8f);
        knockback = false;
    }

    public IEnumerator CD()
    {
        dashasd = false;
        yield return new WaitForSeconds (dashcd);
        dashasd = true;
    }

    public void OnMeleeInput(bool meleeInput)
    {
        melee = true;
        anim.SetTrigger("Melee");

        if ((melee == true) && !IsGrounded())
        {
            
            Debug.Log("hyppylyönti");
            //anim.SetBool("Jump", false);
            anim.SetTrigger("Melee");
            
        }
        
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    public void MeleeWeaponHit()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayerMask);

        foreach(Collider2D coll in hitEnemies)
        {
            if (coll != null)
            {
                coll.GetComponent<HitPoints>().CheckDamage(20, new Vector2(transform.position.x, 0));
            }
        }
    }
  
}