using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    void TriggerDeathVFX()
    {
        if (!deathVFX)
            return;
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
        // Instantiating because the lizard gets destroyed. If we childed the particle effect, then that would be destroyed before it gets played
        Destroy(deathVFXObject, 1f);

    }
}
