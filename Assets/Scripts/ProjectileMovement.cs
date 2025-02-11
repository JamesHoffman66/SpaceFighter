using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    private float speed = 45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //shoots projectile in the direction of the enemy
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
