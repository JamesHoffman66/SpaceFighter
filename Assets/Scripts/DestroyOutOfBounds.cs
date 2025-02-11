using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //variables denoting the positions in which an object will be destroyed when they reach it
    private float rightBound = 55f;
    private float leftBound = -40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //destroys game object when it reaches a certain position
        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        } else if (transform.position.x < leftBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        
    }
}
