using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //sets a speed for the game object to move at
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // makes the game object move forward at the specified speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
