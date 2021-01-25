using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)] float currentSpeed = 1f;
    GameObject currentTarget;

    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    void UpdateAnimationState()
    {
        if (!currentTarget)
            GetComponent<Animator>().SetBool("isAttacking", false);
    }

    public void SetMovementSpeed(float speed)
    // This is called from an Animation Event
    {
        currentSpeed = speed;
    }
    
    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage)
    // This is called from an Animation Event
    {
        if (!currentTarget)
            return;
        Health health = currentTarget.GetComponent<Health>();
        if (health)
            health.DealDamage(damage);
    }
}