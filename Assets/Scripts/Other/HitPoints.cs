using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoints : MonoBehaviour
{
    public int hp;
    public int armor;
    public bool parry = false;
    public float parryTime;

   
    public void OnParryInput(bool parryInput)
    {
        parry = false;
    }



    void TakeDamage(int dmg)
    {
        if(hp > 0)
        {
            hp -= dmg;
        }
        else
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
        dmg -= armor;
        TakeDamage(dmg);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
