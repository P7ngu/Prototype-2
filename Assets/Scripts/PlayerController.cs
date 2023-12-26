using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;

    public float horizontalSpeed = 20.0f;
    public float verticalSpeed = 25.0f;

    public float xRange = 23;
    public float zRange = 10;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ** HORIZONTAL **
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * horizontalSpeed);
        //left side
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //right side
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // ** VERTICAL **
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * verticalSpeed);
        //up
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        // down
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        //Launch the pizza
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //The space has been pressed, let's launch it
            //instantiate, copies of an object that already exists
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            //We use transform.position aka the player's position
        }
        
    }
}
