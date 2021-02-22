using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]GameObject bulletSpawn;
    [SerializeField]Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() 
    {
        
    }

    // Update is called once per frame
    public void OnShootInput(bool shootInput)
    {
        Instantiate(bulletSpawn, firePoint.position, firePoint.rotation);

        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, firePoint.right);

        Debug.Log(hit.collider.tag);

        if (hit)
        {
            Debug.Log("PULLLLLLLLLLLLLLLLLLLLLL");
            if (hit.collider.tag == "Ground")
            {
                Debug.Log("KULLLLLLLLLLLLLLLLL");
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider.tag == "Enemy")
            {

            }
            else
            {

            }
        }
    }
}
