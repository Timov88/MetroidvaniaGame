using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]GameObject bulletSpawn;
    [SerializeField]Transform firePoint;
    Animator anim;
    public bool shooting = false;
    public LayerMask enemyLayerMask;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInParent<Animator>();
    }

    void Update() 
    {
        
    }

    // Update is called once per frame
    public void OnShootInput(bool shootInput)
    {
        shooting = true;
        anim.SetTrigger("Shoot");
        anim.SetBool("Jump", false);
        Instantiate(bulletSpawn, firePoint.position, firePoint.rotation);

        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, firePoint.right, 1000, enemyLayerMask);
        Debug.DrawRay(firePoint.position, firePoint.right, Color.red, 100, false);
        Debug.Log(hit.collider.gameObject.name);

        if (hit)
        {
           
            //Debug.Log("PULLLLLLLLLLLLLLLLLLLLLL");
            if (hit.collider.tag == "Ground")
            {
                Debug.Log("KULLLLLLLLLLLLLLLLL");
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider.tag == "Enemy")
            {
              hit.collider.GetComponent<HitPoints>().CheckDamage(20);
                //Destroy(hit.transform.gameObject);
            }
            else
            {

            }
        }
    }
}
