using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRun : StateMachineBehaviour
{
    Transform player;
    Rigidbody2D rb;
    Enemy enemy;
    float attackRange = 1.4f;
    HitPoints death;
    bool playerDeath;
   




    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponentInParent<Rigidbody2D>();
        enemy = animator.GetComponentInParent<Enemy>();
        death = player.GetComponent<HitPoints>();
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        enemy.LookAtPlayer();
        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, 2 * Time.fixedDeltaTime);
        if (Vector2.Distance(player.position, rb.position) >= attackRange * 0.75f)
        {
            rb.MovePosition(newPos);
        }

        if (Vector2.Distance(player.position, rb.position) <= attackRange )
        {
            
            animator.SetTrigger("Attack");
            enemy.Attack(true);
        }

        if (death.playerDeath == true)
        {
            animator.ResetTrigger("Attack");
            enemy.Attack(false);
            animator.SetBool("Celebration", true);
        }
    }



    //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    if (playerDeath.playerDeath == true)
        {
            animator.ResetTrigger("Attack");
            enemy.Attack(false);
        }


    //}
}

