using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //variable defining the movement speed for the enemy
    private float speed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //enemy moves in the direction of the player character
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
