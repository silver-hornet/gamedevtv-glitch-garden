using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;

    public void Fire()
    // This is called from an Animation Event
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
    }
}