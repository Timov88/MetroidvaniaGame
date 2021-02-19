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
    }
}
