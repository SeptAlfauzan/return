using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;

    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }    
    }
    
    void Attack(){
        animator.SetTrigger("Attack1");
        
        // Collider2D[] enemies
    }
}
