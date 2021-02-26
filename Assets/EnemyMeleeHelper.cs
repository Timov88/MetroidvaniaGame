using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeHelper : MonoBehaviour
{
    public Transform enemyAttackPoint;
    public float enemyAttackRange = 0.5f;
    public LayerMask playerLayerMask;
    Enemy enemy;
   // public CircleCollider2D weaponCollider;

    public void EnemyMeleeWeaponHit()
    {
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(enemyAttackPoint.position, enemyAttackRange, playerLayerMask);

        foreach (Collider2D coll in hitPlayer)
        {
            if (coll != null)
            {
                if (!coll.GetComponent<HitPoints>().parry)
                {
                    coll.GetComponent<HitPoints>().CheckDamage(20, new Vector2(transform.parent.transform.position.x, 0));

                }
                else
                {
                    enemy.EnemyStunned();
                }
            }
        }
    }
    void Start()
    {

        enemy = GetComponentInParent<Enemy>();
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
