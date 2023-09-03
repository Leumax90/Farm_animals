using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float sideBound = 21.0f;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        // Убирает обьекты что прошли верхнею и нижнею границы, и выводит сообщ. конец игры
        if (transform.position.x > sideBound || transform.position.x < -sideBound)
        {
            Destroy(gameObject);
            gameManager.AddLives(-1);
        } else if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        } else if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
}
