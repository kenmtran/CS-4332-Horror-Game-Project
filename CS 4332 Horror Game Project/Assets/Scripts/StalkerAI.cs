using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StalkerAI : MonoBehaviour
{
    public GameObject stalkerDest;
    NavMeshAgent stalkerAgent;
    public GameObject monster;
    public static bool isStalking;
    private bool canAttack = true;
    public float enemyCooldown = 1;
    private float nextSwipeTime;
    Animator monsterAnimator;
    public PlayerCasting player;
    bool m_Attack;
    public AudioSource attack;

    void Start()
    {
        stalkerAgent = GetComponent<NavMeshAgent>();
        monsterAnimator = monster.GetComponent<Animator>();
        m_Attack = false;
        isStalking = true;
    }

    void Update()
    {
        float attackRange = 3f;
        float swingRate = 1.5f;
        if (isStalking == false)
        {
            monster.GetComponent<Animator>().Play("Idle");
        }
        else if (Vector3.Distance(transform.position, stalkerDest.transform.position) < attackRange && canAttack)
        {
            if (Time.time > nextSwipeTime)
            {
                stalkerAgent.isStopped = true;
                stalkerAgent.velocity = Vector3.zero;
                monsterAnimator.SetBool("Attack", true);
                attack.Play();
                //Target within attack range
                //monster.GetComponent<Animator>().Play("Mutant Swiping");
                Debug.Log("Attack should of finished at: " + Time.time);
                //stalkerDest.runDamage = true;
                nextSwipeTime = Time.time + swingRate;
            }

        }
        else {
            if (Time.time > nextSwipeTime)
            {
                stalkerAgent.isStopped = false;
                monsterAnimator.SetBool("Attack", false);
                monster.GetComponent<Animator>().Play("Crouched Walking 1");
                stalkerAgent.SetDestination(stalkerDest.transform.position);
            }
        }



    }

    IEnumerator AttackCooldown()
    {
        Debug.Log("Started Attack Cooldown at:" + Time.time);
        canAttack = false;
        yield return new WaitForSeconds(5);
        canAttack = true;
        Debug.Log("Finished waiting at: " + Time.time);
    }


}
