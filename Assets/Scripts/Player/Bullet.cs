using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField]Rigidbody2D rb;
    [SerializeField]float bulletSpeed;
    [SerializeField]float bulletTime;
    DashTrail dashTrail;
    IEnumerator bullet;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTrail = GetComponent<DashTrail>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2 (transform.localScale.x * bulletSpeed, rb.velocity.y);
        rb.velocity = transform.right * bulletSpeed;
        /*bullet = BulletFly();
        StartCoroutine(bullet);*/
        Destroy(gameObject, 2f);
    }

    void OnTriggerEnter2D(Collider2D hit) {
        Debug.Log(hit.name);
        Debug.Log(hit.gameObject.tag);

        //Laita damage
        /* 
        if (hit.gameObject.tag == anna tagin nimi esim(Enemy)
        {
            Destroy(gameobject);
            tai 
            Take damage tai jotain semmosta
        }
        */
    }

    /*IEnumerator BulletFly()
    {
        dashTrail.InvokeRepeating("SpawnTrailPart",0,0.01f);
        yield return new WaitForSeconds(bulletTime);
        dashTrail.CancelInvoke("SpawnTrailPart");
    }*/
}
