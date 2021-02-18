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
    [SerializeField]Transform bullet;
    [SerializeField]LayerMask platformLayerMask;
    [SerializeField]AudioSource jumpAudio;
    private float horizontal;
    private float vertical;
    bool facingRight = false;
    bool dashing = false;
    Animator anim;
    IEnumerator dash;
    
    

    void Start() 
    {
            rb = GetComponent<Rigidbody2D>();
            boxCollider2D = GetComponent<BoxCollider2D>();
            anim = GetComponent<Animator>();
            dashTrail = GetComponent<DashTrail>();
            
    }

    void FixedUpdate() 
    {
        IsGrounded();
        if (!dashing)
        {
            rb.velocity = new Vector2(horizontal*movementSpeed, rb.velocity.y);
            anim.SetFloat("Run", Mathf.Abs(horizontal));
            anim.speed = Mathf.Abs(horizontal);
        }
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
        //Debug.Log($"{horizontal},{vertical}");
    }

    public void OnJumpInput(bool jumpInput)
    {
        if (IsGrounded())
        {
            
            Debug.Log("SOITA AUDIO");
            //jumpAudio.Play();//
            rb.AddForce(Vector2.up*jumpSpeed, ForceMode2D.Impulse);
        }
    }

    public void OnDashInput(bool dashInput)
    {
        dash = Dash();
        StartCoroutine(dash);
    }

    public void OnShootInput(bool shootInput)
    {
        Instantiate(bullet, new Vector2(1,1), Quaternion.identity);
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
}