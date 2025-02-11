using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables for vertical and horizontal input as well as the range on the z-axis
    //and the speed of the player as it moves
    public float verticalInput;
    public float horizontalInput;
    private float speed = 25;
    private float zRange = 17;

    public GameObject projectilePrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player boundaries for the Z axis allowing the player to move between -17z and 17z 
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        //allows for player movement across a vertical axis at the speed of 25
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        //player boundaried for the x axis allowing the player to move between -27x and 0x
        if (transform.position.x < -32)
        {
            transform.position = new Vector3(-32, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 0)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }

        //allows for player movement across a vertical axis at the speed of 25
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.down * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
