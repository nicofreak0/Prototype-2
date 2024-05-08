using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //sets a distance for the game object to get destroyed at
    private float topBound = 30;
    private float lowerBound = -10;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if the position of the object on z is greater than the top boundary it gets destroyed
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //if the position of the object on z is less than the lower boundary it gets destroyed
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over.");
            Destroy(gameObject);
        }

    }
}
