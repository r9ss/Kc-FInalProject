using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Blood : MonoBehaviour
{
   public float health = 50f;
   Collider Capsule;
   NavMeshAgent nav;
   public void TakeDamage (float amount)
{
     health -= amount;
     if (health <= 0f)
     {
         Die();
     }
}
   void Die()
   {
        gameObject.GetComponent<Animator>().enabled = false;
        Capsule = GetComponent<Collider>();
        Capsule.enabled = !Capsule.enabled;
         nav =  gameObject.GetComponent<NavMeshAgent>();
         nav.enabled = !nav.enabled;
   }
}
