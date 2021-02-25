using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoints : MonoBehaviour
{
    public int hp;
    public int armor;
    public bool parry = false;
    public float parryTime;
    private float timer;
    //public Rigidbody2D rb;
    //public Enemy enemy;
    Animator anim;
    AudioPlayer deathAudio;
    public bool playerDeath;


    public void OnParryInput(bool parryInput)
    {
        parry = true;
        //Debug.Log("parry pressed");
        StartCoroutine(ParryWindow()); 
        
    }

    public void OnCollisionEnter2D (Collision2D other)
    {
       Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if ((parry == true) && (other.gameObject.tag == "Enemy"))
            {
            //Debug.Log("parried!!!!!!!");
            enemy.EnemyStunned();
            
            }
    }

   
    public IEnumerator ParryWindow()
    {
        yield return new WaitForSeconds(2);
        //Debug.Log("parry window closed");
        parry = false;
    }
    void TakeDamage(int dmg)
    {
        if (playerDeath == false)
        {
            hp -= dmg;
            anim.SetBool("Hurt", true);
            if (hp <= 0)
            {
                playerDeath = true;
                deathAudio.DeathSound();
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
        //Destroy(this.gameObject);
        StartCoroutine(DeathWait());
    }

    public IEnumerator DeathWait()
    {
        yield return new WaitForSeconds(5);
        
    }
    public void CheckDamage(int dmg)
    {
        //Debug.Log("h�l�");
        dmg -= armor;
        TakeDamage(dmg);
    }
    
    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
        //enemy = GetComponent<Enemy>();
        anim = GetComponentInChildren<Animator>();
        deathAudio = GetComponentInChildren<AudioPlayer>();
        playerDeath = false;
    }

   
    void Update()
    {
        
    }
}
