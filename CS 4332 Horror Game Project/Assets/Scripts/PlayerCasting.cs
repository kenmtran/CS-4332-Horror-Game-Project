using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float DistanceFromTarget;
    public float ToTarget;
    public int playerHealth;
    public bool runDamage;
    float damageTime;
    float currentDamageTime;
    public bool attackProc;
    public GameObject monsterDist;
    float attackRange;
    float currentTime;
    public AudioSource hurtSound;
    //public float invulnTime = 3.0f;
    //private bool invulnPhasee = false;
    // Update is called once per frame

    void Start()
    {
        playerHealth = 5;
        runDamage = false;
        attackRange = 3f;
        damageTime = 5.0f;
        currentTime = 0;
    }
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            ToTarget = Hit.distance;
            DistanceFromTarget = ToTarget;
        }

        if (playerHealth == 0)
        {
            //transform.position = new Vector3(1.5f, 2.25f, 0.0f);
        }
        if (playerHealth > 0)
            currentTime += Time.deltaTime;
        if ((Vector3.Distance(transform.position, monsterDist.transform.position) < attackRange))
        {

            if (currentTime >= damageTime)
            {
                hurtSound.Play();
                Damage();
            }

        }

    }

    public void Damage()
    {
        playerHealth -= 1;
        currentTime = 0;

    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("The player has entered the enemies trigger");

        if (other.gameObject.CompareTag("Monster")) ;
        {
            //Debug.Log("We have entered the damage");
            currentDamageTime += Time.deltaTime;
            if (currentDamageTime > damageTime)
            {
                playerHealth -= 1;
                currentDamageTime = 0.0f;
            }
        }
    }

}
