using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxhealth = 200;
    public Animator animator;
    int currentHealth;
    void Start()
    {
        currentHealth = maxhealth;
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Damaged");
        if(currentHealth <= 0){
            Die();
        }
    }

    void Die(){
        Debug.Log("im dead");
        animator.SetBool("Dead", true);
        this.enabled = false;
    }
}
