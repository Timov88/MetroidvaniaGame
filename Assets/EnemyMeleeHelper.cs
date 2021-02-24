using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeHelper : MonoBehaviour
{
    public Transform enemyAttackPoint;
    public float enemyAttackRange = 0.5f;
    public LayerMask playerLayerMask;
   // public CircleCollider2D weaponCollider;

    public void EnemyMeleeWeaponHit()
    {
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(enemyAttackPoint.position, enemyAttackRange, playerLayerMask);

        foreach (Collider2D coll in hitPlayer)
        {
            if (coll != null)
            {
                //Debug.Log("player hit");
                coll.GetComponent<HitPoints>().CheckDamage(20);
            }
        }
    }
    void Start()
    {
        //weaponCollider = GetComponent<CircleCollider2D>();
       // weaponCollider.enabled = false;
    }
    public void WeaponColliderEnabler()
    {
       // weaponCollider.enabled = true;
      //  Debug.Log("weapon coll enabled");
    }
    public void WeaponColliderDisabler()
    {
       // weaponCollider.enabled = false;
       // Debug.Log("weapon coll disabled");
    }
}
