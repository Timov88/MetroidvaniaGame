using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeHelper : MonoBehaviour
{
    public Transform enemyAttackPoint;
    public float enemyAttackRange = 0.5f;
    public LayerMask playerLayerMask;

    public void EnemyMeleeWeaponHit()
    {
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(enemyAttackPoint.position, enemyAttackRange, playerLayerMask);

        foreach (Collider2D coll in hitPlayer)
        {
            if (coll != null)
            {
                coll.GetComponent<HitPoints>().CheckDamage(20);
            }
        }
    }
}
