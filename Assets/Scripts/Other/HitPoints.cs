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
        hp -= dmg;
        if (hp <= 0)
        {
            
            KillMe();
        }
        
    }

    void KillMe()
    {
        Destroy(this.gameObject);
    }

    public void CheckDamage(int dmg)
    {
        //Debug.Log("hölö");
        dmg -= armor;
        TakeDamage(dmg);
    }
    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
        //enemy = GetComponent<Enemy>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
