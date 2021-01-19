using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    float speed = 10f;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}