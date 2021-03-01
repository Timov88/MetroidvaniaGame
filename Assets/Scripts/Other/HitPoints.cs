using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HitPoints : MonoBehaviour
{
    
    Rigidbody2D rb;
    public int hp;
    public int maxHealth = 100;
    public int stamina;
    public int maxStamina = 100;
    public int armor;
    public bool parry = false;
    public float parryTime;
    private float timer;
    public bool outofStamina = false;
    
    //public Enemy enemy;
    Animator anim;
    AudioPlayer deathAudio;
    public bool playerDeath = false;
    public GameObject playerDeathObject;
    public HealthBar healthBar;
    public StaminaBar staminaBar;
    private Coroutine regen;

    private WaitForSeconds regenTick = new WaitForSeconds(0.1f);


    public void OnParryInput(bool parryInput)
    {
        parry = true;
        anim.SetBool("Parry", true);
        //Debug.Log("parry pressed");
        StartCoroutine(ParryWindow()); 
        
    }

    // public void OnCollisionEnter2D (Collision2D other)
    //{
    //   Enemy enemy = other.gameObject.GetComponent<Enemy>();
    //    if ((parry == true) && (other.gameObject.tag == "Enemy"))
    //        {
    //        //Debug.Log("parried!!!!!!!");
    //        enemy.EnemyStunned();
            
    //        }
    //}

   
    public IEnumerator ParryWindow()
    {
        yield return new WaitForSeconds(0.7f);
        //Debug.Log("parry window closed");
        parry = false;
        anim.SetBool("Parry", false);
    }
    void TakeDamage(int dmg)
    {
        if (playerDeath == false)
        {
            hp -= dmg;
            healthBar.SetHealth(hp);
            anim.SetBool("Hurt", true);
            if (hp <= 0)
            {
                playerDeath = true;
                deathAudio.DeathSound();
                rb.constraints = RigidbodyConstraints2D.FreezeAll;

                
                KillMe();

            }
            StartCoroutine(HurtWindow());
        }
    }
    public IEnumerator HurtWindow()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("Hurt", false);
    }
    void KillMe()
    {
        //playerDeath = true;
        Debug.Log("you are ded");
        anim.SetBool("Death", true);
        Instantiate(playerDeathObject, transform.position, Quaternion.identity);
        //Destroy(this.gameObject);
        this.enabled = false;
        deathAudio.WitchLaughSound();
        gameObject.SetActive(false);
       // StartCoroutine(DeathWait());
    }

    public IEnumerator DeathWait()
    {
        yield return new WaitForSeconds(5);
        
    }
    public void CheckDamage(int dmg, Vector2 enemy)
    {
        //Debug.Log("hölö");
        //rb.AddForce((rb.position - enemy)*500, ForceMode2D.Impulse);
        GetComponent<PlayerController>().StartCoroutine("KnockBack");
        GetComponent<PlayerController>().knockbackDirection = enemy;
        
        dmg -= armor;
        TakeDamage(dmg);
    }
    public void CheckDamage(int dmg)
    {
        //Debug.Log("hölö");
        
        dmg -= armor;
        TakeDamage(dmg);
    }

    public void UseStamina (int amount)
     {
        if (stamina - amount >= 0)
        {
           
            stamina -= amount;
            staminaBar.SetStamina(stamina);
            
           // outofStamina = false;
           // Debug.Log(outofStamina);
            if (regen != null)
            { 
            StopCoroutine(regen);
            }
            regen = StartCoroutine(RegenStamina());
        }
        
       
        else if (stamina <= 1)
        {
            outofStamina = true;
        }

    }
    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(2);

        while(stamina < maxStamina)
        {
            stamina += maxStamina / 100;
            staminaBar.SetStamina(stamina);
            yield return regenTick;

        }
        regen = null;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //staminaBar = GetComponent<StaminaBar>();
        //enemy = GetComponent<Enemy>();
        anim = GetComponentInChildren<Animator>();
        deathAudio = GetComponentInChildren<AudioPlayer>();
        hp = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        staminaBar.SetMaxStamina(maxStamina);
        stamina = maxStamina;
}


void Update()
    {
        if (stamina >= 10)
        {
            outofStamina = false;
        }
        else
        {
            outofStamina = true;
        }
           
    }
}
