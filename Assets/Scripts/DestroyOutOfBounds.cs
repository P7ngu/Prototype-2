using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) //pizza
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)//animals
        {
            //Debug.Log("Game Over!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            Debug.Log("Game Over!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            Debug.Log("Game Over!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
